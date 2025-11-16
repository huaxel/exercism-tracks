using System.Text;
static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string empId = id.HasValue ? $"[{id}] - " : string.Empty;
        string departmentID = department?.ToUpper() ?? "OWNER";
        StringBuilder badge = new();
        badge.Append(empId);
        badge.Append(name);
        badge.Append($" - {departmentID}");;
        return badge.ToString();
            }
}
