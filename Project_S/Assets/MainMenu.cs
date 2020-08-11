using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    bool wants_to_play;
    public Fade_black fade;
    public void PlayGame() {
        wants_to_play = true;
    }

    public void Update()
    {

        if (wants_to_play) {
            fade.Fade_In();
            if (fade.in_finished) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            }
    }

    public void QuitGame() {
        Application.Quit();
    }
}
