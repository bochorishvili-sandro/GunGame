class WeaponBase
{
    public int Lethality { get; protected set; }
    public int Strength { get; set; }
    public int Accuracy { get; set; }

    public void GenerateLethality()
    {
        Lethality = Strength * 2;
    }
}

class Weapon : WeaponBase
{
    public Weapon(int strength, int accuracy)
    {
        Strength = strength;
        Accuracy = accuracy;
        GenerateLethality();
    }
}