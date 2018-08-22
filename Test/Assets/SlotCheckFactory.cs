using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SlotCheckFactory : MonoBehaviour
{
    public static List<CheckBase<Slot>> ChooseCheckListDependsOnSlotType(Slot s)
    {
        if (s.GetType() == typeof(Slot))
            return GetWonderCheckList();
        else if (s.GetType() == typeof(Slot))
            return GetCardCheckList();
        else return null;
    }

    public static List<CheckBase<Slot>> GetWonderCheckList()
    {
        List<CheckBase<Slot>> _checkList = new List<CheckBase<Slot>>();
        _checkList.Add(new CheckResources());
        _checkList.Add(new CheckGold());
        return _checkList;
    }

    public static List<CheckBase<Slot>> GetCardCheckList()
    {
        List<CheckBase<Slot>> _checkList = new List<CheckBase<Slot>>();
        _checkList.Add(new CheckResources());
        _checkList.Add(new CheckSymbol());
        _checkList.Add(new CheckGold());
        return _checkList;
    }
}
