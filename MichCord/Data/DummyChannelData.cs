namespace MichCord.Data
{
    public class DummyChannelData
    {
        private List<Channel> channels = new List<Channel>
        {
            new Channel("General", "General chat, go nuts."),
            new Channel("Film & TV", "Film and television discussion."),
            new Channel("Gaming", "Video games, tabletop, whatever.")
        };
        public List<Channel> Channels
        {
            get
            {
                return channels;
            }
            set
            {
                channels = value;
                Notify?.Invoke();
            }
        }
        public event Action Notify;

    }
}
