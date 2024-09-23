using System;
using UnityEngine;

public class DetectWinState : MonoBehaviour
{
    public bool levelCompleted = false;
    public GameObject winStateBorder;

    private SpriteRenderer spriteRenderer;
    private float fadeSpeed = 0.4f;
    private Color spriteRendererColor;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = winStateBorder.GetComponent<SpriteRenderer>();
        spriteRendererColor = spriteRenderer.color;
        spriteRendererColor.a = 0;
        spriteRenderer.color = spriteRendererColor;
        winStateBorder.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (levelCompleted)
        {
            if (spriteRendererColor.a < 1)
            {
                spriteRendererColor.a += Time.deltaTime * fadeSpeed; 
                spriteRenderer.color = spriteRendererColor; 
            }
        }
    }

    public void WinCheck()
    {
        levelCompleted = true;
        winStateBorder.SetActive(true);
    }
}