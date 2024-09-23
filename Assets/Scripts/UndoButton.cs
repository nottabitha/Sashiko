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
        int inputBorderNo = playerControllerScript.inputBorderNo;
        int lastInputBorderNo = playerControllerScript.lastinputBorderNo;
        int inputOrderForUndo = inputBorderNo == 1 ? inputBorderNo : 0;
        int lastInputOrderForUndo = lastInputBorderNo == 1 ? lastInputBorderNo : 0;

        if (playerControllerScript.sewPoints.Count > 0)
        {
            Destroy(playerControllerScript.sewPoints[^1]);
            playerControllerScript.sewPoints.RemoveAt(playerControllerScript.sewPoints.Count - 1);

            playerControllerScript.positionsList.RemoveAt(playerControllerScript.positionsList.Count - 1);

            if (playerControllerScript.positionsList.Count - 1 >= 0 && playerControllerScript.positionsList.Count - 1 < playerControllerScript.positionsList.Count)
            {
                playerControllerScript.inputBorders[inputOrderForUndo].transform.position =
                    playerControllerScript.positionsList[^1];
            }
            else
            {
                playerControllerScript.inputBorders[inputOrderForUndo].transform.position = new Vector3(10, 10, 0);
            }
            if (playerControllerScript.positionsList.Count - 2 >= 0 && playerControllerScript.positionsList.Count - 2 < playerControllerScript.positionsList.Count)
            {
                playerControllerScript.inputBorders[lastInputOrderForUndo].transform.position =
                    playerControllerScript.positionsList[^2];
            }
            else
            {
                playerControllerScript.inputBorders[lastInputOrderForUndo].transform.position = new Vector3(10, 10, 0);
            }

            if (playerControllerScript.lineVisible)
            {
                playerControllerScript.lineVisible = false;
            }
            else if (!playerControllerScript.lineVisible)
            {
                playerControllerScript.lineVisible = true;
            }

            if (inputBorderNo == 0)
            {
                playerControllerScript.lastinputBorderNo = 0;
                playerControllerScript.inputBorderNo = 1;
            }
            else if (inputBorderNo == 1)
            {
                playerControllerScript.lastinputBorderNo = 1;
                playerControllerScript.inputBorderNo = 0;
            }
        }

    }
}

    
