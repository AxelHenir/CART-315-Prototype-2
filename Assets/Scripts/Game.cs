using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game : MonoBehaviour
{
    public MainMenu PlayerCountScript;
    public int playerCount;
    public PlayerControls controls;

    public class Player{
        public int points;

        public void gainPoints(int pts){
            this.points += pts;
        }
    }
    public List<Player> playerList = new List<Player>();


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
    
    void Start(){
        gameState = GameState.Menu;
        turnState = TurnState.RollDice;

        playerCount = PlayerCountScript.playerCount;

        for (int i = 0; i < playerCount; i++){
            Player newPlayer = new Player();
            playerList.Add(newPlayer);
        }
        Debug.Log(playerList);
    }

    void confirm(){
        Debug.Log("confirmed");
    }

    void Update(){
        GetInput();
        GameStateHandler();
    }

    public void GetInput(){

    }

    // Handles which UI, camera and such for each "scene" of the game
    public void GameStateHandler(){

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
    public void TurnStateHandler(){

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
