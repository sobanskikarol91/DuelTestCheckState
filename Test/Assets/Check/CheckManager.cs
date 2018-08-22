using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckManager : MonoBehaviour
{
    public static void CheckSlotCardResult(Slot _slot)
    {
        // Problem 1. w zależności od typu slotu chce aby fabryka zwróciła mi odpowiednie 
        // możliwoście za jakie mogę kupić karte np. za zasoby, pieniadze, symbol
        List<CheckBase> checkList = SlotCheckFactory.ChooseCheckListDependsOnSlotType(_slot);

        // dla kazdej mozliwosci wykonuje sprawdzenie czy slot spełnia wymagania
        // i zapamietuje ten wynik w slocie
        checkList.ForEach(c => c.Check(_slot));
    }
}
