namespace AbstractClass;

class Civic : IOtomobil
{
    public Marka HangiMarka()
    {
        return Marka.Honda;
    }

    public int KacTekerlek()
    {
        return 4;
    }

    public Renk StandratRengi()
    {
        return Renk.Gri;
    }
}