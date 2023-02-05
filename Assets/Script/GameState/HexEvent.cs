using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct HexEvent
{
    public HexEvent(Sprite newScreen, int numberOfOptions)
    {
        eventScreen = newScreen;
    }

    public Sprite eventScreen;
}
