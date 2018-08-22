using UnityEngine;
using System.Collections;

public abstract class CheckBase
{
   public abstract Result Check(Slot s);
}

public class CheckResources : CheckBase
{
    public override Result Check(Slot s)
    {

        // sprawdz czy gracz ma wystarczajaca ilosc zasobow
        //s._Card.Price
        throw new System.NotImplementedException();
    }
}

public class CheckGold : CheckBase
{
    public override Result Check(Slot s)
    {

        // sprawdz czy gracz moze kupic brakujace zasoby za zloto
        //s._Card.Price
        throw new System.NotImplementedException();
    }
}

public class CheckSymbol : CheckBase
{
    public override Result Check(Slot s)
    {
        
        // sprawdz czy gracz moze kupic karte za symbol z innej karty
        throw new System.NotImplementedException();
    }
}