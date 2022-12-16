using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Update(){
        // when pressing Esc, a Pause Menu will show up. If already in Pause Menu, it will disappear
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume(){
        Debug.Log("pressed");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        Debug.Log("pressed");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit(){
        Debug.Log("quit");
        Application.Quit();
    }
}