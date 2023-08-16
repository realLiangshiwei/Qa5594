using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Moduleapp.Blazor.Menus;

public class ModuleappMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ModuleappMenus.Prefix, displayName: "Moduleapp", "/Moduleapp", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
