using UnityEngine;
using System.Collections;

public class Slot : MonoBehaviour
{
    public Result _Result { get; set; }
    public BaseCard _Card { get; set; }

    private void Start()
    {
        SlotManager.Subscribe(this);
    }
}
