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
    Hex defaultHexCell;

    public Hex[][] hexCells;

    public HexGrid()
    {
        
    }

    [MenuItem("GridUpdate/Update")]
    static void UpdateGrid()
    {
        //Destroy old cells
        Hex[] tempCells = FindObjectsOfType<Hex>();
        for (int i = 0; i < tempCells.Length; i++)
        {
            Debug.Log("cool");
            DestroyImmediate(tempCells[i], true);
        }

        //Make new cells
        HexGrid[] tempGrids = FindObjectsOfType<HexGrid>();

        if(tempGrids.Length <= 0)
        {
            Debug.Log("No grid in scene");
        }
        else
        {
            for (int i = 0; i < tempGrids.Length; i++)
            {
                tempGrids[i].hexCells = new Hex[tempGrids[i].sizeX][];
                for (int j = 0; j < tempGrids[i].sizeX; j++)
                {
                    tempGrids[i].hexCells[j] = new Hex[tempGrids[i].sizeY];
                    for (int k = 0; k < tempGrids[i].sizeY; k++)
                    {
                        tempGrids[i].hexCells[j][k] = Instantiate(tempGrids[i].defaultHexCell, tempGrids[i].transform);
                        tempGrids[i].hexCells[j][k].hexCoord = new HexCoord(j, k);
                        tempGrids[i].hexCells[j][k].parent = tempGrids[i];
                        Vector3 vector3 = new Vector3(j * tempGrids[i].hexSize, k * tempGrids[i].hexSize);
                        if (k % 2 == 0)
                        {
                            vector3.x += tempGrids[i].hexSize /2;
                        }
                        tempGrids[i].hexCells[j][k].transform.position = vector3;
                        Debug.Log(tempGrids[i].hexCells[j][k].hexCoord.q);
                        Debug.Log(tempGrids[i].hexCells[j][k].hexCoord.r);
                    }
                }
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
