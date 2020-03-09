using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    private TutorialCheck tutorialCheck;
    // Start is called before the first frame update
    void Start()
    {
        tutorialCheck = GameObject.Find("TutorialCheck(Clone)").GetComponent<TutorialCheck>();
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

    public void GoLevel2Scene()
    {
        SceneManager.LoadScene("Level2");
    }

    public void GoLevel3Scene()
    {
        SceneManager.LoadScene("Level3");
    }

    public void GoLevel4Scene()
    {
        SceneManager.LoadScene("Level4");
    }

    public void GoLevel5Scene()
    {
        SceneManager.LoadScene("Level5");
    }

    public void GoLevel6Scene()
    {
        SceneManager.LoadScene("Level6");
    }

    public void GoLevel7Scene()
    {
        SceneManager.LoadScene("Level7");
    }

    public void GoLevel8Scene()
    {
        SceneManager.LoadScene("Level8");
    }
    public void GoCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }   

    public void CloseTutorial()
    {
        tutorialCheck.tutorialComplete = true;
    }
}
