using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Settworks.Hexagons;

public class Hex : MonoBehaviour
{
    public HexCoord hexCoord { get; set; }

    public Sprite background;

    public GameObject hexObject;

    public HexGrid parent;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNeighbors()
    {

        for (int i = 0; i < 5; i++)
        {

            int q = hexCoord.Neighbor(i).q;
            int r = hexCoord.Neighbor(i).r;

            if(q !< 0 && r !< 0)
            {
                if(q !> parent.hexCells.Length - 1 && r !> parent.hexCells[r].Length - 1)
                {
                    parent.hexCells[q][r].Activate();
                }
                
            }
        }
    }

    public void Activate()
    {
        Destroy(gameObject);
    }
}
