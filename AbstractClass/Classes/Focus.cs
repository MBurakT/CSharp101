namespace AbstractClass;

class Focus : IOtomobil
{
    public Marka HangiMarka()
    {
        return Marka.Ford;
    }

    public int KacTekerlek()
    {
        return 4;
    }

    public Renk StandratRengi()
    {
        return Renk.Beyaz;
    }
}