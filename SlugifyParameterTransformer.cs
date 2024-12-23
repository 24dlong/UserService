using System.Text.RegularExpressions;


namespace UserService;

public class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    public string TransformOutbound(object? value)
    {
        if (value != null)
        {
            string valueString = value.ToString() ?? "";
            // Slugify value
            return Regex.Replace(valueString, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
        
        return "";
    }
}