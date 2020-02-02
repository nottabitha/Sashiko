using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewPoint : MonoBehaviour
{
    public AudioSource audio;
    public GameObject controller;
    public PlayerController controllerScript;


    // Start is called before the first frame update
    void Awake()
    {
        audio = GetComponent<AudioSource>();
        controller = GameObject.Find("GameController");
        controllerScript = controller.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlaySound();
    }

    public void PlaySound()
    {
        if (controllerScript.audioPlay == true)
        {
            if (!audio.isPlaying)
            {
                audio.Play();
                controllerScript.audioPlay = false;
            }
        }
    }
}
