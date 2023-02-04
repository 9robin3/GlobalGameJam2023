using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Settworks.Hexagons;

public class Hex : MonoBehaviour
{
    public HexCoord hexCoord { get; set; }

    public Sprite background;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerable<HexCoord> Neighbors()
    {

        IEnumerable<HexCoord> result = hexCoord.Neighbors();
        return result;
    }
}
