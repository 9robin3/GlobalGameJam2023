using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndState : GameState
{
    float cameraSpeed = 1.0f;

    public void GameStateStart()
    {
        Debug.Log("Game Over");
    }

    public void GameStateUpdate()
    {
        
    }
}
