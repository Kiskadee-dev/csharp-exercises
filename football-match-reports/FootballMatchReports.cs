using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string AnalyzeOffField(object report)
    {

        switch (report)
        {
            case string r:
                return $"{r}";
            case int i:
                return $"There are {i} supporters at the match.";
            case Incident incident:
                return incident switch
                {
                    Injury => $"Oh no! {incident.GetDescription()} Medics are on the field.",
                    _ => $"{incident.GetDescription()}"
                };
            case Manager manager:
                string Name = manager.Name;
                string Club = manager.Club != null ? $" ({manager.Club})" : "";
                return $"{Name}{Club}";
            default:
                throw new ArgumentException();
        }
    }
}
