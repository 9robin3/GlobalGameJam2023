using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class HexCell : MonoBehaviour
{
    public HexSide[] hexSides;

    public HexCell()
    {
        hexSides = new HexSide[6];
    }
}
