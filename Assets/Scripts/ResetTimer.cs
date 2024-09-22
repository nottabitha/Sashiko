using UnityEngine;

public class ResetTimer : MonoBehaviour
{
    private SceneSwitcher sceneSwitcher;
    private TutorialCheck tutorialCheck;
    [SerializeField] private float timer = 90;
    private void Awake()
    {
        sceneSwitcher = GameObject.Find("GameController").GetComponent<SceneSwitcher>();
        tutorialCheck = GameObject.Find("TutorialCheck(Clone)").GetComponent<TutorialCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        var isMouseMoved = Input.GetAxis("Mouse X") !=0 || Input.GetAxis("Mouse Y")!=0;

        if (Input.anyKey || isMouseMoved)
        {
            timer = 90;
        }

        if (timer <= 0)
        {
            tutorialCheck.tutorialComplete = false;
            GoMenuScene();
        }
    }
    
    public void GoMenuScene()
    {
        sceneSwitcher.GoMenuScene();
    }
}
