public class CustomSearchSettings
{
    public List<string> IgnoreWords { get; set; } = new List<string>();
    public Dictionary<string, string> ReplacementRules { get; set; } = new Dictionary<string, string>();
}
