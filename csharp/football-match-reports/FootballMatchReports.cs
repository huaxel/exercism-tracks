public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => "UNKNOWN"
        };
    }

    public static string AnalyzeOffField(object report)
    {
        return report switch
        {
            int n => $"There are {n} supporters at the match.",
            string s => s,
            Injury inj => $"Oh no! {inj.GetDescription()} Medics are on the field.",
            Incident inc => inc.GetDescription(),
            Manager mgr when mgr.Club is not null => $"{mgr.Name} ({mgr.Club})",
            Manager mgr => mgr.Name,
            _ => ""
        };
    }
}
