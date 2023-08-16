using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Volo.Abp.Application;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.Abp.Json;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Moduleapp;

[ExposeServices(typeof(IClientProxyApiDescriptionFinder))]
public class MyClientProxyApiDescriptionFinder : IClientProxyApiDescriptionFinder, ISingletonDependency
{
     protected IVirtualFileProvider VirtualFileProvider { get; }
    protected IJsonSerializer JsonSerializer { get; }
    protected Dictionary<string, ActionApiDescriptionModel> ActionApiDescriptionModels { get; }
    protected ApplicationApiDescriptionModel ApplicationApiDescriptionModel { get; set; }

    public MyClientProxyApiDescriptionFinder(
        IVirtualFileProvider virtualFileProvider,
        IJsonSerializer jsonSerializer)
    {
        VirtualFileProvider = virtualFileProvider;
        JsonSerializer = jsonSerializer;
        ActionApiDescriptionModels = new Dictionary<string, ActionApiDescriptionModel>();

        Initialize();
    }

    public ActionApiDescriptionModel FindAction(string methodName)
    {
        return ActionApiDescriptionModels.ContainsKey(methodName) ? ActionApiDescriptionModels[methodName] : null;
    }

    public ApplicationApiDescriptionModel GetApiDescription()
    {
        return ApplicationApiDescriptionModel;
    }

    private void Initialize()
    {
        ApplicationApiDescriptionModel = GetApplicationApiDescriptionModel();
        var controllers = ApplicationApiDescriptionModel.Modules.Select(x => x.Value).SelectMany(x => x.Controllers.Values).ToList();

        foreach (var controller in controllers.Where(x => x.Interfaces.Any()))
        {
            var appServiceType = controller.Interfaces.Last().Type;

            foreach (var actionItem in controller.Actions.Values)
            {
                var actionKey = $"{appServiceType}.{actionItem.Name}.{string.Join("-", actionItem.ParametersOnMethod.Select(x => x.Type))}";

                if (!ActionApiDescriptionModels.ContainsKey(actionKey))
                {
                    ActionApiDescriptionModels.Add(actionKey, actionItem);
                }
            }
        }
    }

    private ApplicationApiDescriptionModel GetApplicationApiDescriptionModel()
    {
        var applicationApiDescription = ApplicationApiDescriptionModel.Create();
        var fileInfoList = new List<IFileInfo>();
        GetGenerateProxyFileInfos(fileInfoList);

        foreach (var fileInfo in fileInfoList)
        {
            using (var streamReader = new StreamReader(fileInfo.CreateReadStream()))
            {
                var content = streamReader.ReadToEnd();

                var subApplicationApiDescription = JsonSerializer.Deserialize<ApplicationApiDescriptionModel>(content);

                foreach (var module in subApplicationApiDescription.Modules)
                {
                    if (!applicationApiDescription.Modules.ContainsKey(module.Key))
                    {
                        applicationApiDescription.AddModule(module.Value);
                    }
                }
            }
        }

        return applicationApiDescription;
    }

    private void GetGenerateProxyFileInfos(List<IFileInfo> fileInfoList, string path = "")
    {
        foreach (var directoryContent in VirtualFileProvider.GetDirectoryContents(path))
        {
            if(directoryContent.PhysicalPath != null && directoryContent.PhysicalPath.Contains("ClientProxies"))
            {
                var qq = directoryContent.GetVirtualOrPhysicalPathOrNull();
            }
            if (directoryContent.IsDirectory)
            {
                
                GetGenerateProxyFileInfos(fileInfoList, directoryContent.PhysicalPath);
            }
            else
            {
                if (directoryContent.Name.EndsWith("generate-proxy.json"))
                {
                    fileInfoList.Add(VirtualFileProvider.GetFileInfo(directoryContent.GetVirtualOrPhysicalPathOrNull()));
                }
            }
        }
    }
}

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ModuleappDomainSharedModule),
    typeof(AbpHttpClientModule),

    typeof(AbpDddApplicationContractsModule)
)]
public class ModuleappDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModuleappDomainModule>();
        });

        context.Services.AddStaticHttpClientProxies(typeof(ModuleappDomainModule).Assembly
            );
    }
}
