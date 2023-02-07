using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : GameState
{
    GameManager manager;
    Image image;
    public Ingridient ingridient;

    public Event(GameManager newManager)
    {
        manager = newManager;
        image = manager.eventCanvas.GetComponentInChildren<Image>();
    }

    public void GameStateStart()
    {
        manager.eventCanvas.enabled = true;
        ChangeImage(ingridient);
        manager.musicManager.PlayEventMusic(ingridient);
    }

    public void GameStateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (manager.currentMoves <= 0)
            {
                manager.eventCanvas.enabled = false;
                manager.ChangeState(manager.endState);
            }
            else
            {
                manager.eventCanvas.enabled = false;
                manager.ChangeState(manager.selectionState);
            }
        }
    }

    void ChangeImage(Ingridient newIngridient)
    {
        Sprite sprite = null;

        switch(newIngridient)
        {
            case Ingridient.camomille:
                sprite = manager.camomilleSprite;
                break;
            case Ingridient.chicory:
                sprite = manager.chicorySprite;
                break;
            case Ingridient.empty:
                break;
            case Ingridient.gravel:
                sprite = manager.gravelSprite;
                break;
            case Ingridient.honey:
                sprite = manager.honeySprite;
                break;
            case Ingridient.mushroom:
                sprite = manager.mushroomSprite;
                break;
            case Ingridient.random:
                break;
            case Ingridient.tapioca:
                sprite = manager.tapiocaSprite;
                break;
            case Ingridient.vanilla:
                sprite = manager.vanillaSprite;
                break;
            case Ingridient.water:
                sprite = manager.waterSprite;
                break;
        }

        image.sprite = sprite;
    }
}
