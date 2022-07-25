using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour
{
    public string levelSelectScene;

    public GameObject firstButton;
    public GameObject optionsFirstButton; // don't need
    public GameObject optionsClosedButton; // don't need
    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(firstButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelectScene);
    }

    public void OptionSelect()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}
