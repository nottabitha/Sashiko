﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayCheck : MonoBehaviour
{
    public GameObject music;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Music") == null)
        {
            Instantiate(music);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
