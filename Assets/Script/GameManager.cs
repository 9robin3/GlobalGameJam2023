using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum Ingridient {empty, random, gravel, vanilla, water, camomille, mushroom, chicory, honey, tapioca };

public class GameManager : MonoBehaviour
{
    GameState currentGameState;
    public SelectionState selectionState { get; private set; }
    public Event eventState { get; private set; }
    public EndState endState { get; private set; }

    public int startMoves;

    public int currentMoves;

    //public Sprite currentEventSprite;

    public Canvas eventCanvas;

    public Canvas endTextCanvas;

    public Button button;

    public MusicManager musicManager;

    public Sprite camomilleSprite;
    public Sprite mushroomSprite;
    public Sprite chicorySprite;
    public Sprite honeySprite;
    public Sprite tapiocaSprite;
    public Sprite gravelSprite;
    public Sprite vanillaSprite;
    public Sprite waterSprite;


    public int gravel;
    public int vanilla;
    public int water;
    public int camomille;
    public int mushroom;
    public int chicory;
    public int honey;
    public int tapioca;

    public void ChangeState(GameState newGameState)
    {
        currentGameState = newGameState;
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
            case Ingridient.random:
                int random = Random.Range(0, 8);
                switch(random)
                {
                    case 0:
                        gravel++;
                        ingridien = Ingridient.gravel;
                        break;
                    case 1:
                        vanilla++;
                        ingridien = Ingridient.vanilla;
                        break;
                    case 2:
                        water++;
                        ingridien = Ingridient.water;
                        break;
                    case 3: 
                        camomille++; 
                        ingridien = Ingridient.camomille;
                        break;
                    case 4:
                        tapioca++;
                        ingridien = Ingridient.tapioca;
                        break;
                    case 5: 
                        chicory++;
                        ingridien = Ingridient.chicory;
                        break;
                    case 6: 
                        honey++;
                        ingridien = Ingridient.honey;
                        break;
                    case 7:
                        mushroom++;
                        ingridien = Ingridient.mushroom;
                        break;
                }
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
            case Ingridient.tapioca:
                tapioca++;
                break;
        }

        if(ingridien != Ingridient.empty)
        {
            eventState.ingridient = ingridien;
            ChangeState(eventState);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentMoves = startMoves;
        eventCanvas.enabled = false;
        endTextCanvas.enabled = false;
        selectionState = new SelectionState(this);
        eventState= new Event(this);
        endState = new EndState(this);
        ChangeState(selectionState);
        musicManager = GetComponent<MusicManager>();

    }

    // Update is called once per frame
    void Update()
    {
        currentGameState.GameStateUpdate();
    }
}
