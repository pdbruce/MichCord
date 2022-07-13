namespace MichCord.Data
{
    public class DummyMessageData
    {
        public Dictionary<string, List<Message>> messages;
        public DummyMessageData(DummyChannelData data)
        {
            messages = new Dictionary<string, List<Message>>();
            foreach(var channel in data.Channels)
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
        // State changes for components
        public Dictionary<string, List<Message>> Messages
        {
            get { 
                return messages; 
            }
            set
            {
                messages = value;
                Notify?.Invoke();
            }
        }
        public event Action Notify;
        // Add a new set of messages
        public void GenerateNewChannelMessages(Channel channel)
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
