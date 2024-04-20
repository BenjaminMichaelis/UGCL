namespace UGCL.Data.Models;

public class Match
{
    public int MatchId { get; set; }
    public int Team1Id { get; set; }
    [ForeignKey(nameof(Team1Id))]
    public Team? Team1 { get; set; }

    public int Team2Id { get; set; }
    [ForeignKey(nameof(Team2Id))]
    public Team? Team2 { get; set; }
    public DateTimeOffset MatchDate { get; set; }
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }
}

