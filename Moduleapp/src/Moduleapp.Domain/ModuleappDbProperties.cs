namespace Moduleapp;

public static class ModuleappDbProperties
{
    public static string DbTablePrefix { get; set; } = "Moduleapp";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Moduleapp";
}
