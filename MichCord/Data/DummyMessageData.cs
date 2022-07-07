namespace MichCord.Data
{
    public class DummyMessageData
    {
        public Dictionary<string, List<Message>> messages;
        public DummyMessageData(DummyChannelData data)
        {
            messages = new Dictionary<string, List<Message>>();
            foreach(var channel in data.channels)
            {
                messages.Add(
                    channel.Name,
                    new List<Message> { 
                        new Message($"hey we're posting in {channel.Name}", new User("FirstName", "LastName", "Username")),
                        new Message("foo", new User("FirstName", "LastName", "Username")),
                        new Message("bar", new User("FirstName", "LastName", "Username")),
                        new Message("baz", new User("FirstName", "LastName", "Username"))
                    }
                );
            }
        }
    }
}
