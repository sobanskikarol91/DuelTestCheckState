using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour
{
    public bool IsPositive { get; private set; }
    public Result(bool isPositive) { IsPositive = isPositive; }
}

public class ResourcesResult : Result
{
    public ResourcesResult(bool isPositive) : base(isPositive) { }
}

public class ResourcesGold : Result
{
    int additionalPayment;

    public ResourcesGold(bool isPositive, int additionalPayment) : base(isPositive)
    { this.additionalPayment = additionalPayment; }
}

public class SymbolResult : Result
{
    public SymbolResult(bool isPositive) : base(isPositive) { }
}
