using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGrid : MonoBehaviour
{
    [SerializeField]
    int sizeX;
    [SerializeField]
    int sizeY;

    HexCell[][] hexCells;

    public HexGrid()
    {
        hexCells = new HexCell[sizeX][];
        for (int i = 0; i < sizeX; i++)
        {
            hexCells[i] = new HexCell[sizeY];
            for (int j = 0; j < sizeY; j++)
            {
                hexCells[i][j] = new HexCell();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
