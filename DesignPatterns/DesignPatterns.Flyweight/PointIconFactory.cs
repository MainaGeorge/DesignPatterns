namespace DesignPatterns.Flyweight;

public static class PointIconFactory
{
    private static readonly Dictionary<PointType, PointIcon> Icons = new();

    public static PointIcon CreatePointIcon(PointType pointType)
    {
        if (Icons.ContainsKey(pointType)) return Icons[pointType];

        var icon = pointType switch
        {
            PointType.CAFE => new PointIcon("cafe_icon_path", pointType),
            PointType.HOSPITAL => new PointIcon("hospital_icon_path", pointType),
            PointType.UNIVERSITY => new PointIcon("university_icon_path", pointType),
            PointType.SCHOOL => new PointIcon("school_icon_path", pointType),
            _ => throw new ArgumentOutOfRangeException(nameof(pointType), pointType, null)
        };

        Icons[pointType] = icon;

        return Icons[pointType];
    }

    public static int NumberOfIconsCreated => Icons.Count;

    public static int GetIconsCreatedByType(PointType pointType)
    {
        return Icons.Count(i => i.Key == pointType);
    }
}