using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCheck : MonoBehaviour
{
    public bool tutorialComplete;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);

        tutorialComplete = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialComplete == false)
        {
            GameObject.FindGameObjectWithTag("Tutorial").transform.localScale = new Vector3(1, 1, 1);
        }
        if (tutorialComplete == true)
        {
            GameObject.FindGameObjectWithTag("Tutorial").transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
