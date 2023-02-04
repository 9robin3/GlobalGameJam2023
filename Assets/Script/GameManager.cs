using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameState currentGameState;

    

    void changeState(GameState newGameState)
    {
        currentGameState = newGameState;
        currentGameState.GameStateStart();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentGameState.GameStateUpdate();
    }
}
