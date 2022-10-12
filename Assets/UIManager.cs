using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public static int playerCount;

    //playerprefs?

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            GameObject.Destroy(this.gameObject);
            return;
        }
    }

    //start new game with int amount of players
    public void PlayGame(int players)
    {
        playerCount = players;
        SceneManager.LoadScene(1);
    }

    //pause game - call on pause input not a button hehe
    public void PauseGame()
    {
        Time.timeScale = 0; //might be better to tell gamemanager to set timescale depending on gamestate
    }

    //resume game
    public void ResumeGame()
    {
        Time.timeScale = 1f; //might be better to tell gamemanager to set timescale depending on gamestate
    }

    //return to menu
    public void ReturnGame()
    {
        Time.timeScale = 1f; //might be better to tell gamemanager to set timescale depending on gamestate
        SceneManager.LoadScene(0);
    }

    //quit game
    public void QuitGame()
    {
        Application.Quit();
    }
}
