using UnityEngine;
using System.Collections;

public abstract class  CheckBase<CardType> where CardType : Slot
{
   public abstract Result Check(CardType s);
}

public class CheckResources : CheckBase<Slot>
{
    public override Result Check(Slot s)
    {

        // sprawdz czy gracz ma wystarczajaca ilosc zasobow
        //s._Card.Price
        throw new System.NotImplementedException();
    }
}

public class CheckGold : CheckBase<Slot>
{
    public override Result Check(Slot s)
    {

        // sprawdz czy gracz moze kupic brakujace zasoby za zloto
        //s._Card.Price
        throw new System.NotImplementedException();
    }
}

public class CheckSymbol : CheckBase<SlotCard>
{
    public override Result Check(SlotCard s)
    {        
        // sprawdz czy gracz moze kupic karte za symbol z innej karty
        throw new System.NotImplementedException();
    }
}