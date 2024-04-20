namespace UGCL.Data.Models;

public class Player
{
    public int PlayerId { get; set; }
    [Required]
    public required string Name { get; set; }
}

