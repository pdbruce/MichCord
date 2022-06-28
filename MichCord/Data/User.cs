namespace MichCord.Data
{
    public class User
    {
        private string firstName { get; set; }

        private string lastName { get; set; }

        public string? userName { get; set; }

        public User(string firstName, string lastName, string username)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = username;
            return;
        }

        public String toString()
        {
            return firstName + " " + lastName;
        }

    }


}
