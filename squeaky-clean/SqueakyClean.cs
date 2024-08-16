using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder builder = new();
        bool thisOneIsUpper = false;
        for (int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];
            if (char.IsControl(c))
            {
                builder.Append("CTRL");
                continue;
            }
            else if (char.IsBetween(c, 'α', 'ω'))
                continue;
            else if (char.IsWhiteSpace(c))
            {
                builder.Append("_");
                continue;
            }
            else if (!char.IsLetter(c) && c != '-')
                continue;
            else if (c == '-')
            {
                /* 
                    Transformar kebab-case em pascalCase
                */
                thisOneIsUpper = true;
                continue;


            }
            if (thisOneIsUpper)
            {
                c = char.ToUpper(c);
                thisOneIsUpper = false;
            }
            builder.Append(c);
        }
        builder.Replace(" ", "_");
        return builder.ToString();
    }
}
