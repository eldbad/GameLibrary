namespace GameLibrary.Domain.Entities;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Developer { get; set; } = null!;
    public Genre? Genre { get; set; }
}