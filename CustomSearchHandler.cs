using System.Text.RegularExpressions;

public class CustomSearchHandler
{
    private readonly CustomSearchSettings _settings;

    public CustomSearchHandler(CustomSearchSettings settings)
    {
        _settings = settings;
    }

    public string ProcessTitle(string originalTitle)
    {
        string processedTitle = originalTitle;

        foreach (var rule in _settings.ReplacementRules)
        {
            processedTitle = Regex.Replace(processedTitle, Regex.Escape(rule.Key) + "(?![a-zA-Z0-9]{2,4}$)", rule.Value);
        }

        foreach (var ignoreWord in _settings.IgnoreWords)
        {
            processedTitle = Regex.Replace(processedTitle, "\\b" + Regex.Escape(ignoreWord) + "\\b", "", RegexOptions.IgnoreCase);
        }

        return processedTitle.Trim();
    }
}
