


class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public List<int> Points { get; set; }

    public User(string firstName, string lastName, int age, List<int> points)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Points = points;
    }

    public int GetTotalPoints()
    {
        return Points.Sum();
    }
}
