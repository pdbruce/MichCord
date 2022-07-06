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
                Notify?.Invoke();
            }
        }
        public event Action Notify;
    }
}
