using System.Text.RegularExpressions;

public partial class DomainNameValidator
{
    public bool validate(string domain)
    {
        return domain.Length <= 253 && ValidDomain().IsMatch(domain);
    }

    [GeneratedRegex(@"^((?!(-|\.))[A-Za-z0-9-]{0,62}(?<!-)\.){1,126}(?=.*[A-Za-z-])(?!(-|\.))[A-Za-z0-9-]{0,61}(?<!-)$")]
    private static partial Regex ValidDomain();
}
