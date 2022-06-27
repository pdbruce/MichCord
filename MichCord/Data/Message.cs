﻿namespace MichCord.Data
{
    public class Message
    {
        private string content { get; set; }
      
        private DateTime timeSent { get; set; }
       
        private User sender { get; set; }

        public Message(string content, User sender)
        {
            this.content = content;
            this.sender = sender;
            timeSent = DateTime.Now;
            return;

        }

        public String toString()
        {
            return content;
        }


    }
}