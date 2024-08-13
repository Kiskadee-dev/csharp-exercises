using System;

static class Badge
{
    public static string Print(int? id, string name, string? department) => $"{(id == null ? String.Empty : $"[{id}] -")} {name} - {(department == null ? "OWNER" : department.ToUpper())}".Trim();
}
