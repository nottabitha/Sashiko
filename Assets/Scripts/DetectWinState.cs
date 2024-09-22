using UnityEngine;

public class DetectWinState : MonoBehaviour
{
    public bool levelCompleted = false;
    public GameObject winStateBorder; 
    // Start is called before the first frame update
    void Start()
    {
        winStateBorder.SetActive(false);
    }

    // Update is called once per frame
    public void WinCheck()
    {
        winStateBorder.SetActive(true);
    }
}