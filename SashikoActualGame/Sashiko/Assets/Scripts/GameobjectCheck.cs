using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameobjectCheck : MonoBehaviour
{
    public GameObject music;
    public GameObject tutorial;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Music") == null)
        {
            Instantiate(music);
        }

        if (GameObject.FindGameObjectWithTag("Tutorial") == null)
        {
            Instantiate(tutorial);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
