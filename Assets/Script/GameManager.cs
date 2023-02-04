using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameState currentGameState;
    SelectionState selectionState;

    

    void changeState(GameState newGameState)
    {
        currentGameState = newGameState;
        currentGameState.GameStateStart();
    }

    // Start is called before the first frame update
    void Start()
    {
        selectionState = new SelectionState();
        changeState(selectionState);

    }

    // Update is called once per frame
    void Update()
    {
        currentGameState.GameStateUpdate();
    }
}
