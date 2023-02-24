using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int playerCount;

    public void PlayGame(){

        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void TwoPlayerGame(){
        playerCount = 2;
        PlayGame();
    }

    public void ThreePlayerGame(){
        playerCount = 3;
        PlayGame();
    }

    public void FourPlayerGame(){
        playerCount = 4;
        PlayGame();
    }
}
