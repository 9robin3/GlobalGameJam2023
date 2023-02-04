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

    public bool open { get; private set; } = false;
    public bool active { get; private set; } = false;

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
        for (int i = 0; i < 6; i++)
        {

            int q = hexCoord.Neighbor(i).q;
            int r = hexCoord.Neighbor(i).r;

            if (q >= 0 && r >= 0)
            {
                Debug.Log(q);
                Debug.Log(r);
                if (q < parent.hexCells.Length && r < parent.hexCells[q].Length)
                {
                    
                    //parent.hexCells[q][r].Activate();
                }
            }
        }
    }

    public void Activate()
    {
        Destroy(gameObject);
        active = true;
    }

    public void Open()
    {
        open = true;
    }
}
