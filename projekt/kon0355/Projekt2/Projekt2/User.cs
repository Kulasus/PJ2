
namespace Projekt2
{
    class User
    {
        public string Username { set; get; } //Slouzi jako primary key v UserCollection
        public int? Score { set; get; }
        public bool? IsActive { set; get; }

        public User()
        {
            Username = "TestBot";
        }
        public User(string username) {
            Username = username;
        }
        public User(string username, int? score, bool? isActive) : this(username)
        {
            Score = score;
            IsActive = isActive;
        }
    }
}
