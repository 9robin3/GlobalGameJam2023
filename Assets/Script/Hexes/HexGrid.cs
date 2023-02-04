using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;

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

    Hex[][] hexCells;

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
                        Instantiate(tempGrids[i].hexCells[j][k].background, tempGrids[i].hexCells[j][k].transform);
                        tempGrids[i].hexCells[j][k].transform.localPosition = GivePosition(j, k, tempGrids[i].hexSize);
                    }
                }
            }
        }
        
    }

    static Vector3 GivePosition(float x, float y, float size)
    {
        Vector3 result = new Vector3();

        result.x = x * size;
        result.y = y * size;

        if(x%2 == 0)
        {
            result.y += size/2;
        }

        return result;
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
