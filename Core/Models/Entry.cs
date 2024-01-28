namespace Core;

public record Entry
{
    public DateTime AddedUTC { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public List<string> URLs { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public string Note { get; set; } = string.Empty;    
}

public class Group
{

}
