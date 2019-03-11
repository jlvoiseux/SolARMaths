using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    public GameObject cube;
    public GameObject panel;
    public GameObject cursor;
    public float previousMagnitude;
    public float thresholdMag = 1f;
    public float testMag;


    // Called by GazeGestureManager when the user performs a Select gesture

    void Start()
    {
        Vector3 testCurs = 5 * cursor.transform.position;
        previousMagnitude = testCurs.magnitude;
    }
    void Update()
    {
        Vector3 testPos = 5 * cursor.transform.position;
         testMag = Mathf.Abs(testPos.magnitude - previousMagnitude);
        if (cube.GetComponent<TextCommands>().isPlaneMoving == true && testMag < thresholdMag)
        {
            panel.transform.position = testPos;
            panel.transform.rotation = Quaternion.Euler(90f, cursor.transform.eulerAngles.y, cursor.transform.eulerAngles.z);
            previousMagnitude = testPos.magnitude;
        }


    }

    void OnSelect()
    {
        if (cube.GetComponent<TextCommands>().isPlaneMoving == true)
        {
            cube.GetComponent<TextCommands>().isPlaneMoving = false;
        }
        else
        {
            cube.GetComponent<TextCommands>().isPlaneMoving = true;
        }
    }

    void OnSolution()
    {
        // Just do the same logic as a Select gesture.
        DestroyImmediate(panel);
    }



    void OnClose()
    {
        // Just do the same logic as a Select gesture.
        DestroyImmediate(panel);
    }

}