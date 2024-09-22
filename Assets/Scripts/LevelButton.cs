using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioClip audio;
    public Sprite hoverSprite;
    public Sprite normalSprite;
    
    private Button button;
    private AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        button = GetComponent<Button>();
        
        if (audioManager != null)
        {
            button.onClick.AddListener(OnButtonPress);
        }
    }

    private void OnButtonPress()
    {
        audioManager.PlaySound(audio);
        Debug.Log("button pressed");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.GetComponent<Image>().sprite = hoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.GetComponent<Image>().sprite = normalSprite;
    }



}
