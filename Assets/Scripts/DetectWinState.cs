using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DetectWinState : MonoBehaviour
{
    private string sceneName;
    private Scene currentScene;
    private List<Vector3> positionList;

    public PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        //
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        positionList = playerControllerScript.positionsList;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void WinCheck()
    {
        
    }
}