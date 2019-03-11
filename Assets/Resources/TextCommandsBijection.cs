using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class TextCommandsBijection : MonoBehaviour
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
        panel = (GameObject)Instantiate(Resources.Load("Bijection"));
        panel.GetComponent<MovePlane>().cube = cube;
        panel.GetComponent<MovePlane>().cursor = cursor;
        panel.GetComponent<MovePlane>().panel = panel;

        isPlaneMoving = true;
        
    }

    // Called by SpeechManager when the user says the "Drop sphere" command
    

}