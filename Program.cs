namespace _12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { Login = "user1", Name = "John Doe", IsPremium = true },
                new User { Login = "user2", Name = "Jane Smith", IsPremium = false },
                new User { Login = "user3", Name = "Mike Johnson", IsPremium = true },
                new User { Login = "user4", Name = "Emily Davis", IsPremium = false },
                new User { Login = "user5", Name = "David Wilson", IsPremium = true },
                new User { Login = "user6", Name = "Sarah Brown", IsPremium = false },
                new User { Login = "user7", Name = "Alex Anderson", IsPremium = true },
                new User { Login = "user8", Name = "Olivia Lee", IsPremium = false },
                new User { Login = "user9", Name = "James Miller", IsPremium = true },
                new User { Login = "user10", Name = "Sophia Taylor", IsPremium = false }
            };

            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
                if (!user.IsPremium)
                {
                    ShowAds();
                }
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}