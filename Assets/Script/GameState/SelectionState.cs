using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionState : GameState
{
    GameManager manager;

    public SelectionState(GameManager newManager)
    {
        manager = newManager;
    }

    public void GameStateStart()
    {
        
    }

    public void GameStateUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit ray = new RaycastHit();

            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out ray);

            if(hit) 
            {
                if (ray.transform.gameObject.tag == "Hex")
                {
                    Hex hex = ray.transform.gameObject.GetComponent<Hex>();
                    if(hex.open && !hex.active)
                    {
                        hex.Activate();
                        manager.currentMoves--;
                        manager.AddIngridient(hex.ingridient);
                        //if (hex.ingridient != Ingridient.empty)
                        //{
                        //    Debug.Log(hex.ingridient);
                        //    manager.StartEvent(hex.eventScreen);
                        //}
                    }
                }
                
            }
        }
    }
}
