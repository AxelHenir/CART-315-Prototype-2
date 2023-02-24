using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game : MonoBehaviour
{
    public MainMenu PlayerCountScript;
    public int playerCount;
    public PlayerControls controls;

    public class Build{
        public Vector3 location;
        
        public bool isRoof;
        public int value;

        public int score(){
            if(isRoof){
                return 0;
            } else {
                return value * (int)location.z;
            }
        }
    }

    public class Player{
        public int points;
        public List<int> rolls = new List<int>();

        public List<Build> builds = new List<Build>(); 

        public void gainPoints(int pts){
            this.points += pts;
        }
    }
    public List<Player> playerList = new List<Player>();
    public int activePlayer;


    public TurnState turnState;
    public enum TurnState{
        NewTurn,
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
        turnState = TurnState.NewTurn;

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

        TurnStateHandler();

    }

    // Handles the mechanics of the turn
    public void TurnStateHandler(){

        switch (turnState){

            case TurnState.NewTurn:
                break;

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

    // Press Button to begin turn

    // Roll 2 D6 - 
    public void rollDice(){

        playerList[activePlayer].rolls.Add(Random.Range(1,7));
        playerList[activePlayer].rolls.Add(Random.Range(1,7));
        turnState = TurnState.ChooseDieToBuild;
        
    }

    // Player chooses which die to build with

    // Player chooses which spot to build on
    
    // Building

    // Scoring takes place with other die's result



}
