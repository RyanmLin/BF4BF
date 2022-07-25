using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public string mainMenuScene;
    public GameObject pauseMenu;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Pause()
    {
        if(isPaused)
        {
            ResumeGame();
        }
        else
        {
            isPaused = true;
            pauseMenu.SetActive(isPaused);
            Time.timeScale = 0f;
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(isPaused);
        Time.timeScale = 1f;
    }

    public void ReturnToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
