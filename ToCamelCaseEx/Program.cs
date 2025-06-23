using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ToCamelCase("the_stealth_warrior"));
        Console.WriteLine(ToCamelCase("The-Stealth-Warrior"));
    }

    public static string ToCamelCase(string str)
    {
        var sb = new StringBuilder();
        var splittedString = str.Split('-', '_');
        for(int i = 0; i < splittedString.Length; i++)
        {
            if(i == 0)
            {
                sb.Append($"{splittedString[i]}");
            }
            else
            {
                var firstLetter = splittedString[i].Substring(0, 1).ToUpper();
                var lastParthOfString = splittedString[i].Substring(1);
                sb.Append($"{firstLetter}{lastParthOfString}");
            }
        }
        return sb.ToString();
    }

    public static string ToCamelCaseLinq(string str) =>
        string.Concat((str
            .Split('-', '_')
            .Select((x,i) => i == 0 ? x : $"{char.ToUpper(x[0])}{x.Substring(1)}")));
    
}