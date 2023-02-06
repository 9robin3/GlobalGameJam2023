using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : GameState
{
    GameManager manager;

    public Event(GameManager newManager)
    {
        manager = newManager;
    }

    public void GameStateStart()
    {
        manager.eventCanvas.enabled = true;
        manager.eventCanvas.GetComponentInChildren<Image>().sprite = manager.currentEvent;
    }

    public void GameStateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (manager.currentMoves <= 0)
            {
                manager.eventCanvas.enabled = false;
                manager.changeState(manager.endState);
            }
            else
            {
                manager.eventCanvas.enabled = false;
                Debug.Log("Event");
                manager.changeState(manager.selectionState);
            }
        }
    }
}
