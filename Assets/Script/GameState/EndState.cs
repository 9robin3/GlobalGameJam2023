using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndState : GameState
{
    GameManager manager;

    float cameraSpeed = 3.0f;
    float movementDistance = 20;
    float currentMove;

    public EndState(GameManager manager)
    {
        this.manager = manager;
    }

    public void GameStateStart()
    {
        currentMove = 0;
        Debug.Log("Game Over");
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
            manager.RestartGame();
        }


        
    }
}
