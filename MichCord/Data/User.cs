namespace MichCord.Data
{
    public class User
    {
        public string? ID { get; set; }

        public string? firstName { get; set; }

        public string? lastName { get; set; }

        public string? userName { get; set; }

        public List<Message> Messages { get; set; }


        public User(string firstName, string lastName, string username)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = username;
            ID = new Guid().ToString();
            return;
        }

        public String toString()
        {
            return firstName + " " + lastName;
        }

    }


}
