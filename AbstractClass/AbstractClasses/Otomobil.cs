namespace AbstractClass;

abstract class Otomobil
{
    public int KacTekerlek()
    {
        return 4;
    }

    public virtual Renk StandratRengi()
    {
        return Renk.Beyaz;
    }
    public abstract Marka HangiMarka();
}