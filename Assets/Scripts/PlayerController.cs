using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool clicked = false;
    private RaycastHit2D SewPointHit;
    public int inputBorderNo;
    public int lastinputBorderNo;
    public GameObject[] inputBorders;
    public GameObject[] inputPoints;
    public bool audioPlay;
    public List<Vector3> winPositionList;
    public AudioClip audio;

    public List<Vector3> positionsList;
    public GameObject LineRenderer;
    private GameObject lastPointCheck;
    public bool lineVisible = true;
    private bool sewReady = false;
    private int lineNo;
    private GameObject lastPoint;
    private bool hasPlayed = false;
    private GameObject letters;
    private AudioManager audioManager;
    private bool levelCompleted = false;
    private DetectWinState detectWinState;

    public List<GameObject> sewPoints;
    //private GameObject point1;
    //private GameObject point2;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        detectWinState = FindObjectOfType<DetectWinState>();
        
        sewPoints = new List<GameObject>();
        letters = GameObject.Find("Letters");
        letters.SetActive(false);

        inputBorderNo = 0;
    }

    void Awake()
    {
        for (int i = 0; i < inputBorders.Length; i++)
        {
            inputBorders[i].SetActive(false);
        }
        /*
        for (int i = 0; i < inputPoints.Length; i++)
        {
            inputPoints[i].AddComponent<LineRenderer>();
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        CheckWinCondition(winPositionList);
            
        if (Input.GetKeyUp(KeyCode.A))
        {
            lastPoint = GameObject.Find("SewingPointA");
            PointHighlight(GameObject.Find("SewingPointA"));
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            lastPoint = GameObject.Find("SewingPointB");
            PointHighlight(GameObject.Find("SewingPointB"));
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            lastPoint = GameObject.Find("SewingPointC");
            PointHighlight(GameObject.Find("SewingPointC"));
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            lastPoint = GameObject.Find("SewingPointD");
            PointHighlight(GameObject.Find("SewingPointD"));
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            lastPoint = GameObject.Find("SewingPointE");
            PointHighlight(GameObject.Find("SewingPointE"));
        }
        else if (Input.GetKeyUp(KeyCode.F))
        {
            lastPoint = GameObject.Find("SewingPointF");
            PointHighlight(GameObject.Find("SewingPointF"));
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            lastPoint = GameObject.Find("SewingPointG");
            PointHighlight(GameObject.Find("SewingPointG"));
        }
        else if (Input.GetKeyUp(KeyCode.H))
        {
            lastPoint = GameObject.Find("SewingPointH");
            PointHighlight(GameObject.Find("SewingPointH"));
        }
        else if (Input.GetKeyUp(KeyCode.I))
        {
            lastPoint = GameObject.Find("SewingPointI");
            PointHighlight(GameObject.Find("SewingPointI"));
        }
        else if (Input.GetKeyUp(KeyCode.J))
        {
            lastPoint = GameObject.Find("SewingPointJ");
            PointHighlight(GameObject.Find("SewingPointJ"));
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            lastPoint = GameObject.Find("SewingPointK");
            PointHighlight(GameObject.Find("SewingPointK"));
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            lastPoint = GameObject.Find("SewingPointL");
            PointHighlight(GameObject.Find("SewingPointL"));
        }
        else if (Input.GetKeyUp(KeyCode.M))
        {
            lastPoint = GameObject.Find("SewingPointM");
            PointHighlight(GameObject.Find("SewingPointM"));
        }
        else if (Input.GetKeyUp(KeyCode.N))
        {
            lastPoint = GameObject.Find("SewingPointN");
            PointHighlight(GameObject.Find("SewingPointN"));
        }
        else if (Input.GetKeyUp(KeyCode.O))
        {
            lastPoint = GameObject.Find("SewingPointO");
            PointHighlight(GameObject.Find("SewingPointO"));
        }
        else if (Input.GetKeyUp(KeyCode.P))
        {
            lastPoint = GameObject.Find("SewingPointP");
            PointHighlight(GameObject.Find("SewingPointP"));
            audioPlay = false;
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            if (letters.activeSelf == false)
            {
                letters.SetActive(true);
            }
            else if (letters.activeSelf == true)
            {
                letters.SetActive(false);
            }
        }
        /*
        if (inputBorders[0].activeSelf && inputBorders[1].activeSelf)
        {
            if (sewReady)
            {
                if (lineVisible)
                {
                    Sew(lastPoint);
                }
                else
                {
                    lineVisible = true;
                }
            }
        }
        */

        
    }

    void PointHighlight(GameObject point)
    {
        Vector3 newPointPosition = point.transform.position;
        Vector3 lastPositionOne = inputBorders[0].transform.position;
        Vector3 lastPositionTwo = inputBorders[1].transform.position;

        if ((lastPositionOne != newPointPosition) && (lastPositionTwo != newPointPosition))
        {
            positionsList.Add(new Vector3(newPointPosition.x, newPointPosition.y, newPointPosition.z));
            int lastPosition = positionsList.Count - 1;
            GameObject lastSew = Instantiate(LineRenderer, new Vector3(positionsList[lastPosition].x, positionsList[lastPosition].y, positionsList[lastPosition].z), Quaternion.identity);
            sewPoints.Add(lastSew);
            lastPointCheck = point;
            audioPlay = true;
            point.GetComponent<SewPoint>().PlaySound();
            sewReady = true;
            inputBorders[inputBorderNo].SetActive(true);
            inputBorders[inputBorderNo].transform.position = newPointPosition;

            if (inputBorderNo == 0)
            {
                lastinputBorderNo = 0;
                inputBorderNo = 1;
            }
            else if (inputBorderNo == 1)
            {
                lastinputBorderNo = 1;
                inputBorderNo = 0;
            }

            if (inputBorders[0].activeSelf && inputBorders[1].activeSelf)
            {
                if (sewReady)
                {
                    if (lineVisible)
                    {
                        Sew(lastSew);
                    }
                    else
                    {
                        lineVisible = true;
                    }
                }
            }

        }

        else if (inputBorders[0].activeSelf && inputBorders[1].activeSelf)
        {
            if (newPointPosition != inputBorders[lastinputBorderNo].transform.position)
            {
                Debug.Log(lastinputBorderNo);
                positionsList.Add(new Vector3(newPointPosition.x, newPointPosition.y, newPointPosition.z));
                int lastPosition = positionsList.Count - 1;
                GameObject lastSew = Instantiate(LineRenderer, new Vector3(positionsList[lastPosition].x, positionsList[lastPosition].y, positionsList[lastPosition].z), Quaternion.identity);
                sewPoints.Add(lastSew);
                audioPlay = true;
                point.GetComponent<SewPoint>().PlaySound();
                sewReady = true;
                inputBorders[inputBorderNo].SetActive(true);
                inputBorders[inputBorderNo].transform.position = newPointPosition;

                if (inputBorderNo == 0)
                {
                    lastinputBorderNo = 0;
                    inputBorderNo = 1;
                }
                else if (inputBorderNo == 1)
                {
                    lastinputBorderNo = 1;
                    inputBorderNo = 0;
                }

                if (inputBorders[0].activeSelf && inputBorders[1].activeSelf)
                {
                    if (sewReady)
                    {
                        if (lineVisible)
                        {
                            Sew(lastSew);
                        }
                        else
                        {
                            lineVisible = true;
                        }
                    }
                }
            }
        }
    }


    void Sew(GameObject point)
    {
        //sewReady = false;
        
        for (int i = 0; i < inputBorders.Length; i++)
        {
            lineNo = point.GetComponent<LineRenderer>().positionCount;
            point.GetComponent<LineRenderer>().positionCount++;
            point.GetComponent<LineRenderer>().SetPosition(lineNo, inputBorders[i].transform.position);
            lineNo++;
            lineVisible = false;            
        }
    }

    public void CheckWinCondition(List<Vector3> winPattern)
    {
        if (!levelCompleted)
        {
            if (winPattern.Count != positionsList.Count)
            {
                return;
            }
        
            foreach (var segment in winPattern)
            {
                if (!positionsList.Contains(segment))
                {
                    return;
                }
            }
            
            levelCompleted = true;
            detectWinState.levelCompleted = true;
            detectWinState.WinCheck();
            audioManager.PlaySound(audio);
        }
    }
}
