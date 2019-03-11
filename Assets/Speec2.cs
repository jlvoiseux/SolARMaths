using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speec2 : MonoBehaviour
{
    public GameObject proofGroup1;
    public SpriteRenderer proof21;
    public SpriteRenderer proof22;
    public SpriteRenderer proof23;
    public SpriteRenderer proof24;
    public SpriteRenderer proof25;
    public GameObject proofGroup2;
    public Vector3 previousPosition;
    public SpriteRenderer proof31;
    public SpriteRenderer proof32;
    public SpriteRenderer proof33;
    public SpriteRenderer proof34;
    public GameObject proofGroup3;
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

        proof31.color = new Color(255f, 255f, 255f, 0f);
        proof32.color = new Color(0f, 0f, 0f, 0f);
        proof33.color = new Color(0f, 0f, 0f, 0f);
        proof34.color = new Color(0f, 0f, 0f, 0f);        
    }

    // Update is called once per frame
    void Update()
    {
        if (disappearStart == true && appearStart == false)
        {
            proof22.color = new Color(0f, 0f, 0f, 0f);
            proof23.color = new Color(0f, 0f, 0f, 0f);
            proof24.color = new Color(0f, 0f, 0f, 0f);
            proof25.color = new Color(0f, 0f, 0f, 0f);
            

            if (hasStarted == false)
            {
                proof21.GetComponent<Animation>().Play("proof3GroupAnim");
                hasStarted = true;
            }
            if (!proof21.GetComponent<Animation>().isPlaying && hasStarted == true)
            {
                appearStart = true;
            }

        }
        else if (appearStart == true && hasStarted == true)
        {
            hasStarted = false;
            appearStart = true;
            previousPosition = proofGroup2.transform.position;
            proofGroup2.transform.position = new Vector3(10000f, 10000f, 10000f);
            proof31.GetComponentInChildren<TextCommands>().enabled = false;
            proof32.GetComponentInChildren<TextCommands>().enabled = false;
            proof33.GetComponentInChildren<TextCommands>().enabled = false;
            proof34.GetComponentInChildren<TextCommands>().enabled = false;

            proofGroup3.transform.position = previousPosition;

        }
        else if (appearStart == true && hasStarted == false)
        {



            if (hasFinished == false)
            {
                proof31.GetComponent<Animation>().Play("proof4GroupAnim");
                hasFinished = true;
            }
            if (!proof31.GetComponent<Animation>().isPlaying && hasFinished == true)
            {
                proof31.GetComponentInChildren<TextCommands>().enabled = true;
                proof32.GetComponentInChildren<TextCommands>().enabled = true;
                proof33.GetComponentInChildren<TextCommands>().enabled = true;
                proof34.GetComponentInChildren<TextCommands>().enabled = true;


                Destroy(proofGroup2);
            }
        }


    }

    void OnSolution()
    {
        if (proofGroup1 == null)
        {
            disappearStart = true;
        }
    }
}