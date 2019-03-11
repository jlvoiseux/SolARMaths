using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speec3 : MonoBehaviour
{
    public GameObject proofGroup2;

    public SpriteRenderer proof31;
    public SpriteRenderer proof32;
    public SpriteRenderer proof33;
    public SpriteRenderer proof34;
    public GameObject proofGroup3;
    public Vector3 previousPosition;
    public SpriteRenderer proof41;
    public SpriteRenderer proof42;
    public SpriteRenderer proof43;
    public SpriteRenderer proof44;
    public SpriteRenderer proof45;
    public GameObject proofGroup4;
    public bool disappearStart = false;
    public bool appearStart = false;
    public float fadeSpeed = 1f;
    public float fadeTime = 0.25f;
    public float Fade;
    public bool hasStarted = false;
    public bool hasFinished = false;


    // Use this for initialization
    void Start()
    {
        Fade = 255f;

        proof41.color = new Color(255f, 255f, 255f, 0f);
        proof42.color = new Color(0f, 0f, 0f, 0f);
        proof43.color = new Color(0f, 0f, 0f, 0f);
        proof44.color = new Color(0f, 0f, 0f, 0f);
        proof45.color = new Color(0f, 0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (disappearStart == true && appearStart == false)
        {
            proof32.color = new Color(0f, 0f, 0f, 0f);
            proof33.color = new Color(0f, 0f, 0f, 0f);
            proof34.color = new Color(0f, 0f, 0f, 0f);


            if (hasStarted == false)
            {
                proof31.GetComponent<Animation>().Play("proof5GroupAnim");
                hasStarted = true;
            }
            if (!proof31.GetComponent<Animation>().isPlaying && hasStarted == true)
            {
                appearStart = true;
            }

        }
        else if (appearStart == true && hasStarted == true)
        {
            hasStarted = false;
            appearStart = true;
            previousPosition = proofGroup3.transform.position;
            proofGroup3.transform.position = new Vector3(10000f, 10000f, 10000f);
            proof41.GetComponentInChildren<TextCommands>().enabled = false;
            proof42.GetComponentInChildren<TextCommands>().enabled = false;
            proof43.GetComponentInChildren<TextCommands>().enabled = false;
            proof44.GetComponentInChildren<TextCommands>().enabled = false;
            proof45.GetComponentInChildren<TextCommands>().enabled = false;
            proofGroup4.transform.position = previousPosition;

        }
        else if (appearStart == true && hasStarted == false)
        {



            if (hasFinished == false)
            {
                proof41.GetComponent<Animation>().Play("proof6GroupAnim");
                hasFinished = true;
            }
            if (!proof41.GetComponent<Animation>().isPlaying && hasFinished == true)
            {
                proof41.GetComponentInChildren<TextCommands>().enabled = true;
                proof42.GetComponentInChildren<TextCommands>().enabled = true;
                proof43.GetComponentInChildren<TextCommands>().enabled = true;
                proof44.GetComponentInChildren<TextCommands>().enabled = true;
                proof45.GetComponentInChildren<TextCommands>().enabled = true;


                Destroy(proofGroup3);
            }
        }


    }

    void OnSolution()
    {
        if (proofGroup2 == null)
        {
            disappearStart = true;
        }
    }
}