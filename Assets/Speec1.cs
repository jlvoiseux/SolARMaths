using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speec1 : MonoBehaviour
{
    public GameObject enonceGroup;
    public SpriteRenderer proof11;
    public SpriteRenderer proof12;    
    public GameObject proofGroup1;
    public Vector3 previousPosition;
    public SpriteRenderer proof21;
    public SpriteRenderer proof22;
    public SpriteRenderer proof23;
    public SpriteRenderer proof24;
    public SpriteRenderer proof25;
    public GameObject proofGroup2;
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
        
        proof21.color = new Color(255f, 255f, 255f, 0f);
        proof22.color = new Color(0f, 0f, 0f, 0f);
        proof23.color = new Color(0f, 0f, 0f, 0f);
        proof24.color = new Color(0f, 0f, 0f, 0f);
        proof25.color = new Color(0f, 0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (disappearStart == true && appearStart == false)
        {
            proof12.color = new Color(0f, 0f, 0f, 0f);            

            //if (hasStarted == false)
            //{
              //  proof11.GetComponent<Animation>().Play("proof1GroupAnim");
                hasStarted = true;
            //}
            //if (!proof11.GetComponent<Animation>().isPlaying && hasStarted == true)
            //{
                appearStart = true;
            //}

        }
        else if (appearStart == true && hasStarted == true)
        {
            hasStarted = false;
            appearStart = true;
            previousPosition = proofGroup1.transform.position;
            proofGroup1.transform.position = new Vector3(10000f, 10000f, 10000f);
            proof21.GetComponentInChildren<TextCommands>().enabled = false;
            proof22.GetComponentInChildren<TextCommands>().enabled = false;
            proof23.GetComponentInChildren<TextCommands>().enabled = false;
            proof24.GetComponentInChildren<TextCommands>().enabled = false;
            proof25.GetComponentInChildren<TextCommands>().enabled = false;


            proofGroup2.transform.position = previousPosition;

        }
        else if (appearStart == true && hasStarted == false)
        {



            if (hasFinished == false)
            {
                proof21.GetComponent<Animation>().Play("proof2GroupAnim");
                hasFinished = true;
            }
            if (!proof21.GetComponent<Animation>().isPlaying && hasFinished == true)
            {
                proof21.GetComponentInChildren<TextCommands>().enabled = true;
                proof22.GetComponentInChildren<TextCommands>().enabled = true;
                proof23.GetComponentInChildren<TextCommands>().enabled = true;
                proof24.GetComponentInChildren<TextCommands>().enabled = true;
                proof25.GetComponentInChildren<TextCommands>().enabled = true;

                Destroy(proofGroup1);
            }
        }


    }

    void OnSolution()
    {
        if (enonceGroup == null)
        {
            disappearStart = true;
        }
    }
}

