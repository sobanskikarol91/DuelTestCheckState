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
        throw new System.NotImplementedException();
    }
}

public class CheckSymbol : CheckBase
{
    public override Result Check(Slot s)
    {
        throw new System.NotImplementedException();
    }

    public override Result Check(Slot s)
    {
        throw new System.NotImplementedException();
    }
}