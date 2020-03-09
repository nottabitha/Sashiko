using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UndoButton : MonoBehaviour
{
    public PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Undo()
    {
        if (playerControllerScript.sewPoints.Count > 0)
        {
            for (int i = 0; i < 2; i++)
            {
                Destroy(playerControllerScript.sewPoints[playerControllerScript.sewPoints.Count - 1]);
                playerControllerScript.sewPoints.RemoveAt(playerControllerScript.sewPoints.Count - 1);
            }

            playerControllerScript.positionsList.RemoveAt(playerControllerScript.positionsList.Count - 1);

            playerControllerScript.inputBorders[0].transform.position = new Vector3(10, 10, 0);
            playerControllerScript.inputBorders[1].transform.position = new Vector3(10, 10, 0);

            playerControllerScript.inputBorderNo = 0;
        }

    }
}

    
