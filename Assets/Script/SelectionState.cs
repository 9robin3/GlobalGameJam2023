using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionState : GameState
{
    public void GameStateStart()
    {
        
    }

    public void GameStateUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Debug.Log("hit");
            RaycastHit ray = new RaycastHit();

            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out ray);

            if(hit) 
            {
                Debug.Log("hit");
                if (ray.transform.gameObject.tag == "Hex")
                {
                    Debug.Log("selected");
                }
                
            }
        }
    }

}
