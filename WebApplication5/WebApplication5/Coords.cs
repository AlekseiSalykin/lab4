namespace WebApplication5;

public partial class Coords
{
    public long Id { get; set; }

    public string Lat { get; set; } = null!;

    public string Lon { get; set; } = null!;

    public long CityId { get; set; }

    public virtual ICollection<City> Cities { get; } = new List<City>();
}
