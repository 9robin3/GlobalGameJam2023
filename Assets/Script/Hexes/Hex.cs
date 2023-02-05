using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class Hex : MonoBehaviour
{
    SpriteRenderer renderer;

    public Sprite eventScreen;

    public Sprite activeSprite;

    public Sprite openSprite;

    public HexGrid parent;

    public Coord coord;

    public bool open = false;

    public bool active = false;

    public Ingridient ingridient;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNeighbors()
    {
        Coord topLeft = new Coord(coord.x, coord.y + 1);
        Coord topRight = new Coord(coord.x + 1, coord.y + 1);
        Coord left = new Coord(coord.x - 1, coord.y);
        Coord right = new Coord(coord.x + 1, coord.y);
        Coord bottomLeft = new Coord(coord.x, coord.y - 1);
        Coord bottomRight = new Coord(coord.x + 1, coord.y - 1);

        if (coord.y%2 == 1)
        {
            topLeft = new Coord(coord.x - 1, coord.y + 1);
            topRight = new Coord(coord.x, coord.y + 1);
            bottomLeft = new Coord(coord.x - 1, coord.y - 1);
            bottomRight = new Coord(coord.x, coord.y - 1);
        }

        Coord[] coords = new Coord[] { topLeft, topRight, left, right, bottomLeft, bottomRight};

        for (int i = 0; i < coords.Length; i++)
        {
            if(CheckNeighbourInBounds(coords[i]))
            {
                parent.hexCells[coords[i].x][coords[i].y].Open();
            }
            
        }
    }

    public bool CheckNeighbourInBounds(Coord neighbourCoords)
    {
        if(neighbourCoords.x >= 0 && neighbourCoords.y >= 0)
        {
            if(neighbourCoords.x < parent.hexCells.Length)
            {
                if(neighbourCoords.y < parent.hexCells[neighbourCoords.x].Length)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void Activate()
    {
        OpenNeighbors();
        active = true;
        renderer.sprite = activeSprite;
    }

    public void Open()
    {
        if(!open)
        {
            open = true;
            renderer.sprite = openSprite;
        }
    }
}
