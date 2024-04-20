namespace UGCL.Data.Models;

[Index(nameof(Player1Id), nameof(Player2Id), IsUnique = true)]
public class Team
{
    public int TeamId { get; set; }

    // Navigation properties for players
    public int Player1Id { get; set; }
    public Player? Player1 { get; set; }

    public int Player2Id { get; set; }
    public Player? Player2 { get; set; }
}
