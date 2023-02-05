using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum Ingridient {empty, Random, gravel, vanilla, water, camomille, mushroom, chicory, honey, Tapioca };

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

    int gravel;
    int vanilla;
    int water;
    int camomille;
    int mushroom;
    int chicory;
    int honey;
    int tapioca;

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

    public void AddIngridient(Ingridient ingridien)
    {
        switch(ingridien)
        {
            case Ingridient.empty:
                //Do nothing
                break;
            case Ingridient.gravel:
                gravel++;
                break; 
            case Ingridient.vanilla:
                vanilla++;
                break;
            case Ingridient.water:
                water++;
                break;
            case Ingridient.camomille:
                camomille++;
                break;
            case Ingridient.chicory:
                chicory++;
                break;
            case Ingridient.mushroom: 
                mushroom++;
                break;
            case Ingridient.honey: 
                honey++;
                break;
            case Ingridient.Tapioca:
                tapioca++;
                break;
        }
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
