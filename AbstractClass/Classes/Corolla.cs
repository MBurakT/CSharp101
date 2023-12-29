namespace AbstractClass;

class Corolla : IOtomobil
{
    public Marka HangiMarka()
    {
        return Marka.Toyota;
    }

    public int KacTekerlek()
    {
        return 4;
    }

    public Renk StandratRengi()
    {
        return Renk.Mavi;
    }
}