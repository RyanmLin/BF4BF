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
            isPaused = false;
            pauseMenu.SetActive(isPaused);
        }
        else
        {
            isPaused = true;
            pauseMenu.SetActive(isPaused);
        }
    }

    public void ResumeGame()
    {

    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
