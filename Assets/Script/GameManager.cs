using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum Ingridient { gravel, vanilla};

public class GameManager : MonoBehaviour
{
    GameState currentGameState;
    public SelectionState selectionState;
    public Event eventState;
    public EndState endState { get; private set; }

    public int startMoves;

    public int currentMoves;

    public Sprite currentEvent;

    public Canvas eventCanvas;

    public Button button;

    public void changeState(GameState newGameState)
    {
        currentGameState = newGameState;
        currentGameState.GameStateStart();
    }

    public void StartEvent(Sprite eventSprite)
    {
        currentEvent = eventSprite;
        currentGameState = eventState;
        currentGameState.GameStateStart();
    }

    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentMoves = startMoves;
        eventCanvas.enabled = false;
        selectionState = new SelectionState(this);
        eventState= new Event(this);
        endState = new EndState(this);
        changeState(selectionState);

    }

    // Update is called once per frame
    void Update()
    {
        currentGameState.GameStateUpdate();
    }
}
