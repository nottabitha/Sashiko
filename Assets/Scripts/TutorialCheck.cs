using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCheck : MonoBehaviour
{
    public bool tutorialComplete;

    private bool isTutorialNotNull;

    // Start is called before the first frame update
    void Start()
    {
        isTutorialNotNull = GameObject.FindGameObjectWithTag("Tutorial") != null;
        DontDestroyOnLoad(transform.gameObject);

        tutorialComplete = false;

    }

    // Update is called once per frame
    void Update()
    {
        switch (tutorialComplete)
        {
            case false when isTutorialNotNull:
                GameObject.FindGameObjectWithTag("Tutorial").transform.localScale = new Vector3(1, 1, 1);
                break;
            case true when isTutorialNotNull:
                GameObject.FindGameObjectWithTag("Tutorial").transform.localScale = new Vector3(0, 0, 0);
                break;
        }
    }
}
