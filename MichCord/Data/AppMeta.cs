namespace MichCord.Data
{
    public class AppMeta
    {
        private static DummyChannelData data = new DummyChannelData();
        private Channel currentChannel = data.channels[0];
        public Channel CurrentChannel
        {
            get
            {
                return currentChannel;   
            }
            set
            {
                currentChannel = value;
                // Invoke custom event on set()
                Notify?.Invoke();
            }
        }
        // Custom event
        public event Action Notify;
    }
}
