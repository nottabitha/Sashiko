using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoLevelsScene()
    {
        SceneManager.LoadScene("Levels");
    }

    public void GoLevel1Scene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GoCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }   
}
