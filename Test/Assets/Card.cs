using UnityEngine;
using System.Collections;

public class BaseCard
{
    public Resources Price { get; private set; }
}

public class Wonder : BaseCard
{

}

public class Card : BaseCard
{
    int symbol;
}
