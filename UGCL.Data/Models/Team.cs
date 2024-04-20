namespace UGCL.Data.Models;

public class Team
{
    public int TeamId { get; set; }
    public int Player1Id { get; set; }
    [ForeignKey(nameof(Player1Id))]
    public Person? Player1 { get; set; }

    public int Player2Id { get; set; }
    [ForeignKey(nameof(Player2Id))]
    public Person? Player2 { get; set; }
}

