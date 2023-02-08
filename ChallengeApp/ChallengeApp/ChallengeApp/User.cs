namespace ChallengeApp
{
    public class User
    {
        //ta zmienna jest zwiazana z typem
        public static string GameName = "Diablo";

        private List<int> score = new List<int>();
        //konstruktor
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;



        }

        //modyfikator  , pole
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }


        //metoda
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
        public static void AddScore1(int number)
        {

        }

    }
}
