using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using Settworks.Hexagons;

public class HexGrid : MonoBehaviour
{
    [SerializeField]
    int sizeX;
    [SerializeField]
    int sizeY;
    [SerializeField]
    float hexSize;

    [SerializeField]
    Hex defaultHex;

    [SerializeField]
    Hex[] hexes0 = new Hex[16];

    [SerializeField]
    Hex[] hexes1 = new Hex[16];

    [SerializeField]
    Hex[] hexes2 = new Hex[16];

    [SerializeField]
    Hex[] hexes3 = new Hex[16];

    [SerializeField]
    Hex[] hexes4 = new Hex[16];

    [SerializeField]
    Hex[] hexes5 = new Hex[16];

    [SerializeField]
    Hex[] hexes6 = new Hex[16];

    [SerializeField]
    Hex[] hexes7 = new Hex[16];

    [SerializeField]
    Hex[] hexes8 = new Hex[16];

    [SerializeField]
    Hex[] hexes9 = new Hex[16];

    [SerializeField]
    Hex[] hexes10 = new Hex[16];

    [SerializeField]
    Hex[] hexes11 = new Hex[16];

    [SerializeField]
    Hex[] hexes12 = new Hex[16];

    [SerializeField]
    Hex[] hexes13 = new Hex[16];

    [SerializeField]
    Hex[] hexes14 = new Hex[16];

    [SerializeField]
    Hex[] hexes15 = new Hex[16];

    public Hex[][] hexCells;

    public HexGrid()
    {
        
    }

    //[MenuItem("GridUpdate/Update")]
    //static void UpdateGrid()
    //{
    //    HexGrid[] tempGrids = FindObjectsOfType<HexGrid>();

        
    //    if (tempGrids.Length <= 0)
    //    {
    //        Debug.Log("No grid in scene");
    //    }
    //    else
    //    {
    //        for (int i = 0; i < tempGrids.Length; i++)
    //        {
    //            HexGrid currentGrid = tempGrids[i];

    //            //Destroy old cells
    //            Hex[] tempCells = currentGrid.GetComponentsInChildren<Hex>();
    //            for (int j = 0; j < tempCells.Length; j++)
    //            {
    //                Debug.Log("cool");
    //                DestroyImmediate(tempCells[j], true);
    //            }

    //            currentGrid.hexCells = new Hex[currentGrid.sizeX][];

    //            //Make new cells
    //            for (int j = 0; j < currentGrid.sizeX; j++)
    //            {
    //                currentGrid.hexCells[j] = new Hex[currentGrid.sizeY];

    //                for (int k = 0; k < currentGrid.sizeY; k++)
    //                {
    //                    currentGrid.hexCells[j][k] = Instantiate(currentGrid.defaultHex, currentGrid.transform);
    //                    currentGrid.hexCells[j][k].coord = new Coord(j, k);
    //                    currentGrid.hexCells[j][k].parent = currentGrid;

    //                    Vector3 vector3 = new Vector3(j * currentGrid.hexSize, k * currentGrid.hexSize);
    //                    if (k % 2 == 0)
    //                    {
    //                        vector3.x += currentGrid.hexSize /2;
    //                    }
    //                    currentGrid.hexCells[j][k].transform.position = vector3;

    //                    Debug.Log( "X " + currentGrid.hexCells[j][k].coord.x + " : Y " + currentGrid.hexCells[j][k].coord.y);
    //                }
    //            }
    //        }
    //    }
        
    //}

    public void MakeGrid()
    {
        hexCells = new Hex[sizeX][];
        for (int j = 0; j < sizeX; j++)
        {
            //This is ugly I know :(
            switch (j)
            {
                case 0:
                    hexCells[j] = hexes0;
                    break;
                case 1:
                    hexCells[j] = hexes1;
                    break;
                case 2:
                    hexCells[j] = hexes2;
                    break;
                case 3:
                    hexCells[j] = hexes3;
                    break;
                case 4:
                    hexCells[j] = hexes4;
                    break;
                case 5:
                    hexCells[j] = hexes5;
                    break;
                case 6:
                    hexCells[j] = hexes6;
                    break;
                case 7:
                    hexCells[j] = hexes7;
                    break;
                case 8:
                    hexCells[j] = hexes8;
                    break;
                case 9:
                    hexCells[j] = hexes9;
                    break;
                case 10:
                    hexCells[j] = hexes10;
                    break;
                case 11:
                    hexCells[j] = hexes11;
                    break;
                case 12:
                    hexCells[j] = hexes12;
                    break;
                case 13:
                    hexCells[j] = hexes13;
                    break;
                case 14:
                    hexCells[j] = hexes14;
                    break;
                case 15:
                    hexCells[j] = hexes15;
                    break;
            }

            for (int k = 0; k < hexCells[j].Length; k++)
            {
                if(hexCells[j][k] is null)
                {
                    hexCells[j][k] = Instantiate(defaultHex, transform);
                }
                else
                {
                    hexCells[j][k] = Instantiate(hexCells[j][k], transform);
                }
                hexCells[j][k].coord = new Coord(j, k);
                hexCells[j][k].parent = this;

                Vector3 vector3 = transform.position;
                vector3 += new Vector3(j * hexSize, k * hexSize);
                if (k % 2 == 0)
                {
                    vector3.x += hexSize / 2;
                }
                hexCells[j][k].transform.position = vector3;

                Debug.Log("X " + hexCells[j][k].coord.x + " : Y " + hexCells[j][k].coord.y);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MakeGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
