using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SlotManager : MonoBehaviour
{
    static List<Slot> _slots;

    public static void Subscribe(Slot s)
    {
        _slots.Add(s);
    }

    public static void Unsubscribe(Slot s)
    {
        _slots.Remove(s);
    }

    public static void CheckStates()
    {
        _slots.ForEach(s => CheckManager.CheckSlotCardResult(s));
    }
}
