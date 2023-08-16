using Volo.Abp.Settings;

namespace Myapp.Settings;

public class MyappSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyappSettings.MySetting1));
    }
}
