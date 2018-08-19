using UnityEngine;
using System.Collections;

public class Slot : MonoBehaviour 
{
    Result _Result;
    Card _card;

    private void Start()
    {
        SlotManager.Subscribe(this);    
    }
}
