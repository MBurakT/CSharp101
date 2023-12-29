namespace AbstractClass;

class NewCivic : Otomobil
{
    public override Marka HangiMarka()
    {
        return Marka.Honda;
    }

    public override Renk StandratRengi()
    {
        // return base.StandratRengi();
        return Renk.Gri;
    }
}