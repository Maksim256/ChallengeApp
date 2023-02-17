namespace ChallengeApp
{
    public class User
    {

        public static string GameName = "Diablo";
        // private string login;  //w property zostało ustawione odwołanie i to jest nie potrzebne
        //private string password;
        private List<int> score = new List<int>();

        //konstruktor
        public User(string login)
        {
            this.Login = login;
        }

        public User(string login, string password)
        {
            this.Password = password;
            this.Login = login;

        }

        //propercje - pola, czyli publiczna , typ i jej nazwa 
        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }



        //metoda  czy coś zwraca w tym przypadku void czyli nie
        public void AddScore(int number)
        {
            this.score.Add(number);  //bo jest lista i metoda add dla listy
        }
    }
}