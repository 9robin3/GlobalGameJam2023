using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndState : GameState
{
    GameManager manager;

    float cameraSpeed = 3.0f;
    float movementDistance = 20;
    float currentMove = 0;
    float mamaReactionTime = 0;

    public EndState(GameManager manager)
    {
        this.manager = manager;
    }

    public void GameStateStart()
    {
        manager.musicManager.EndStateSound();
    }

    public void GameStateUpdate()
    {
        if(currentMove < movementDistance)
        {
            Camera.main.transform.position += Vector3.up * cameraSpeed * Time.deltaTime;
            currentMove += cameraSpeed * Time.deltaTime;
        }
        else
        {
            if(!manager.endTextCanvas.enabled)
            {
                manager.endTextCanvas.enabled = true;
                manager.endTextCanvas.GetComponentInChildren<TextMeshProUGUI>().text = MamaReaction();
            }

            if(Input.GetMouseButtonDown(0))
            {
                manager.RestartGame();
            }
            
        }
    }

    public string MamaReaction() 
    {
        string reaction = "This tea is";

        if(manager.water <= 0) 
        {
            reaction += " very dry";
        }
        else
        {
            if(manager.mushroom > 0)
            {
                reaction += " silly";
            }
            if(manager.chicory > 0)
            {
                reaction += " nutty";
            }
            if(manager.honey > 0)
            {
                reaction += " sweet";
            }
            if(manager.tapioca > 0)
            {
                reaction += " chewy";
            }
            if(manager.camomille > 0)
            {
                reaction += " soothing";
            }
            if(manager.gravel > 0)
            {
                reaction += " crunchy";
            }
            if(manager.vanilla > 0)
            {
                reaction += "nilla";
            }
        }

        reaction += "!";
        return reaction;
    }
}
