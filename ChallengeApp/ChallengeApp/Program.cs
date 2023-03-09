

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Andrzej", "Dudek", 35, new List<int>() { 5, 8, 6, 9, 7 });
        User user2 = new User("Katarzyna", "Madej", 28, new List<int>() { 6, 7, 5, 8, 9 });
        User user3 = new User("Michał", "Maniara", 55, new List<int>() { 9, 8, 10, 7, 6 });

        List<User> users = new List<User>() { user1, user2, user3 };

        User bestUser = users.OrderByDescending(u => u.GetTotalPoints()).First();

        Console.WriteLine($"Najlepszy użytkownik: {bestUser.FirstName} {bestUser.LastName}");
        Console.WriteLine($"Wiek: {bestUser.Age}");
        Console.WriteLine($"Punkty: {string.Join(", ", bestUser.Points)}");
        Console.WriteLine($"Suma punktów: {bestUser.GetTotalPoints()}");
    }
}
