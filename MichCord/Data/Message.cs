namespace MichCord.Data
{
    public class Message
    {
        public string? content { get; set; }
      
        public DateTime? timeSent { get; set; }
       
        public User? sender { get; set; }
        public int UserID { get; set; }
        public int ChannelID { get; set; }

        public Message(string content, User sender)
        {
            this.content = content;
            this.sender = sender;
            timeSent = DateTime.Now;
            return;

        }

         public String printMessage()
        {
            return content;
        }


    }
}
