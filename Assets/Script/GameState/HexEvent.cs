using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct HexEvent
{
    public HexEvent(Sprite newScreen, int numberOfOptions, Ingridient newReward)
    {
        eventScreen = newScreen;
        options = numberOfOptions;
        reward = newReward;
    }

    public Sprite eventScreen;
    public int options;
    public Ingridient reward;
}
