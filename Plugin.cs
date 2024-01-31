using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Plugins;

public class CustomSearchPlugin : BasePlugin<CustomSearchSettings>, IHasWebPages
{
    public override string Name => "Custom Search Plugin";

    public CustomSearchPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    public static CustomSearchPlugin Instance { get; private set; }

    public override Guid Id => new Guid("12345678-90ab-cdef-1234-567890abcdef");

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return new[]
        {
            new PluginPageInfo
            {
                Name = "CustomSearchConfigPage",
                EmbeddedResourcePath = GetType().Namespace + ".Configuration.CustomSearchConfigPage.html"
            }
        };
    }
}
