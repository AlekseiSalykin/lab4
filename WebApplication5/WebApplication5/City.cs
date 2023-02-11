namespace WebApplication5;

public partial class City
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string District { get; set; } = null!;

    public long Population { get; set; }

    public string Subject { get; set; } = null!;

    public long CoordsId { get; set; }

    public virtual Coords Coords { get; set; } = null!;
}
