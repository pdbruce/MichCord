namespace MichCord.Data
{
    public class Channel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Message> Messages { get; set; }
        public Channel(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
    }
}
