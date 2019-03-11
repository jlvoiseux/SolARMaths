using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class TextCommands : MonoBehaviour
{
    public SpriteRenderer enonce;
    public GameObject enonceGroup;
    public bool isEnonceOn = false;
    public bool hasPlane;
    public bool isPlaneMoving = false;
    public GameObject Plane;
    public GameObject InputManager;
    GameObject panel;
    public GameObject cube;
    public GameObject cursor;
    public bool Natural;
    public bool Real;
    public bool Injection;
    public bool Bijection;
    public bool Countable;
    public bool Initial;
    public bool Contradiction;
    public bool Ex1;
    public bool Ex2;
    public bool Ex3;
    public bool Ex4;
    public int NextFlag = 0;

    private void Awake()
    {
        enonce.color = new Color(0f, 0f, 0f, 0f);        
        isEnonceOn = false;
    }

    public void OnGazed()
    {
        if (isEnonceOn == false)
        {            
            enonce.color = new Color(255f, 255f, 255f, 255f);
            isEnonceOn = true;
        }
    }
    public void OnNotGazed()
    {
        if (isEnonceOn == true)
        {
            enonce.color = new Color(0f, 0f, 0f, 0f);
            isEnonceOn = false;
        }
    }
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        if (Natural == true) {
            panel = (GameObject)Instantiate(Resources.Load("Natural"));
        }
        else if (Real == true) {
            panel = (GameObject)Instantiate(Resources.Load("Real"));
        }
        else if (Injection == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("Injection"));
        }
        else if (Bijection == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("Bijection"));
        }
        else if (Countable == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("Countable"));
            NextFlag = 1;
        }
        else if (Initial == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("Initial"));
        }
        else if (Contradiction == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("Contradiction"));
        }
        else if (Ex1 == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("ex1def"));
            NextFlag = 1; 
        }
        else if (Ex2 == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("ex2def"));
        }
        else if (Ex3 == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("ex3def"));
        }
        else if (Ex4 == true)
        {
            panel = (GameObject)Instantiate(Resources.Load("ex4def"));
        }
        else
        {
           // panel = (GameObject)Instantiate(Resources.Load("Plane"));
        }
       
        panel.GetComponent<MovePlane>().cube = cube;
        panel.GetComponent<MovePlane>().cursor = cursor;
        panel.GetComponent<MovePlane>().panel = panel;

        isPlaneMoving = true;
        
    }

    // Called by SpeechManager when the user says the "Drop sphere" command
    

}