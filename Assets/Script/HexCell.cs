using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HexCell : MonoBehaviour
{
    public HexSide[] hexSides;

    public HexCell()
    {
        hexSides = new HexSide[6];
    }
}
