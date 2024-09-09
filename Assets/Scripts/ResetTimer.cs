using UnityEngine;

public class ResetTimer : MonoBehaviour
{
    private SceneSwitcher sceneSwitcher;
    [SerializeField] private float timer = 300;
    private void Awake()
    {
        sceneSwitcher = GameObject.Find("GameController").GetComponent<SceneSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        var isMouseMoved = Input.GetAxis("Mouse X") !=0 || Input.GetAxis("Mouse Y")!=0;

        if (Input.anyKey || isMouseMoved)
        {
            timer = 300;
        }

        if (timer <= 0)
        {
            GoMenuScene();
        }
    }
    
    public void GoMenuScene()
    {
        sceneSwitcher.GoMenuScene();
    }
}
