using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game : MonoBehaviour
{
    public PlayerControls controls;


    public GameState gameState;
    public enum GameState{
        Menu,
        Tutorial,
        PlayerSelect,
        InGame
    }

    public TurnState turnState;
    public enum TurnState{
        RollDice,
        ChooseDieToBuild,
        ChooseSpotToBuild,
        Build,
        Score,
        Block,
    }

    void Awake(){
        controls = new PlayerControls();

        //Callbacks
        controls.Gameplay.Confirm.performed += context => confirm();
    }

    void OnEnable(){
        controls.Gameplay.Enable();
    }

    void OnDisable(){
        controls.Gameplay.Disable();
    }
    
    void Start()
    {
        gameState = GameState.Menu;
        turnState = TurnState.RollDice;
    }

    void confirm(){
        Debug.Log("confirmed");
    }

    void Update()
    {
        GetInput();
        GameStateHandler();
    }

     // Handles input
    private void GetInput(){

    }

    // Handles which UI, camera and such for each "scene" of the game
    private void GameStateHandler(){

        switch (gameState){
            case GameState.Menu:
                
                break;

            case GameState.Tutorial:
                
                break;

            case GameState.PlayerSelect:
                
                break;

            case GameState.InGame:

                TurnStateHandler();
                break;
            
        }
    }

    // Handles the mechanics of the turn
    private void TurnStateHandler(){

        switch (turnState){
            case TurnState.RollDice:
                
                break;
            case TurnState.ChooseDieToBuild:
                
                break;
            case TurnState.ChooseSpotToBuild:
                
                break;
            case TurnState.Build:
                
                break;
            case TurnState.Score:
                
                break;
        }

    }

}
