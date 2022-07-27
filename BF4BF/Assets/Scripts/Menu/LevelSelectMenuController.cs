using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelSelectMenuController : MonoBehaviour
{
    public string levelOne;
    public string levelTwo;
    public string levelThree;
    public string levelFour;
    public string levelFive;
    public string back;

    public GameObject firstButton;
    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(firstButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelOne()
    {
        SceneManager.LoadScene(levelOne);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(levelTwo);
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(levelThree);
    }

    public void LevelFour()
    {
        SceneManager.LoadScene(levelFour);
    }

    public void LevelFive()
    {
        SceneManager.LoadScene(levelFive);
    }

    public void Back()
    {
        SceneManager.LoadScene(back);
    }
}
