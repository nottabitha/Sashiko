using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource audio;
    public Sprite hoverSprite;
    public Sprite normalSprite;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<Button>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(delegate () { audio.Play(); });
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
