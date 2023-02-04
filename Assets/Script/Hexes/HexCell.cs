using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class HexCell : MonoBehaviour
{
    public HexSide[] hexSides;

    public float size;

    public GameObject background;

    public Hex hex;

    public HexCell()
    {
        hexSides = new HexSide[6];
    }

    private void Start()
    {
        
    }
}
