namespace CA1Animals;

public class Validators
{
    /// <summary>
    /// Check if input means yes or no.
    /// </summary>
    /// <param name="input">Text like "yes", "yes", "no", or "no"</param>
    /// <returns></returns>
    public static bool? IsYesNo(string input)
    {
       
        if (input == null) return null;
        string s = input.Trim().ToLower();
        if (s == "y" || s == "yes") return true;
        if (s == "n" || s == "no")  return false;
        return null;
    }
    /// <summary>
    /// Try  parse an int
    /// </summary>
    /// <param name="input">The text to parse</param>
    /// <param name="number">The parsed number if true</param>
    /// <returns>True if parsed, else false</returns>
    public static bool TryInt(string input, out int number)
    {
        return int.TryParse(input, out number);
    }
}

