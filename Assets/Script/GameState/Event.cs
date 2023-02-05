using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        manager.eventCanvas.GetComponent<SpriteRenderer>().sprite = manager.currentEvent.eventScreen;
    }

    public void GameStateUpdate()
    {
        if(manager.currentMoves <= 0)
        {
            manager.eventCanvas.enabled = false;
            manager.changeState(manager.endState);
        }
        else
        {
            Debug.Log("Event");
            manager.changeState(manager.selectionState);
        }
    }
}
