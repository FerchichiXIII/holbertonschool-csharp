using System;

enum Rating
{
    Good, Great, Excellent
}
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog (string _name, float _age, string _owner, Rating _rating)
    {
        name = _name;
        age = _age;
        owner = _owner;
        rating = _rating;
    }
    public override string ToString()
    {
        return string.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRatng: {3}", name, age, owner, rating);
    }
}
