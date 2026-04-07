namespace Week10;

public class Person
{
    public string Name { get; }
    public string Role { get; }
    public string Level { get; set; }
    public int Health { get; set; }
    public double HowMuchGold { get; set; }
    public string StatusPersona { get; set; }

    public Person(string name,string role,string level, string statusperso,double howMuchGold=0,int health=100)
    {
        Name = name;
        Role = role;
        Level = level;
        StatusPersona = statusperso;
        HowMuchGold = howMuchGold;
        Health = health;
    }
}