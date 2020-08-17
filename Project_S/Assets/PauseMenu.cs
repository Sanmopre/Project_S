using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GamePause = false;
    public GameObject pauseMenuUI;
    public Animator transition;
    public float transitionTime = 1f;

    public bool fading_in = false;

    public Fade_black fade;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {


            if (GamePause)
            {
                Resume();
            }
            else {
                Pause();
            }
        
        }


        if (fading_in) {
            fade.Fade_In();
            if (fade.in_finished)
            {
                SceneManager.LoadScene("Main_menu");
            }

        }


    }


    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;

    
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }

    public void LoadMenu() {
        Time.timeScale = 1f;
        fading_in = true;
    }

    public void QuitGame() {
        Application.Quit();
    }



}
