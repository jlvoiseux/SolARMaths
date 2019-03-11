using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speec5 : MonoBehaviour
{
    public GameObject proofGroup4;

    public SpriteRenderer proof51;
    public SpriteRenderer proof52;  
    public GameObject proofGroup5;
    public Vector3 previousPosition;
    public SpriteRenderer proof61;
    public SpriteRenderer proof62;
    public SpriteRenderer proof63;
    public SpriteRenderer proof64;
    public SpriteRenderer proof65;
    public SpriteRenderer proof66;
    public SpriteRenderer proof67;
    public GameObject proofGroup6;
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

        proof61.color = new Color(255f, 255f, 255f, 0f);
        proof62.color = new Color(0f, 0f, 0f, 0f);
        proof63.color = new Color(0f, 0f, 0f, 0f);
        proof64.color = new Color(0f, 0f, 0f, 0f);
        proof65.color = new Color(0f, 0f, 0f, 0f);
        proof66.color = new Color(0f, 0f, 0f, 0f);
        proof67.color = new Color(0f, 0f, 0f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (disappearStart == true && appearStart == false)
        {
            proof52.color = new Color(0f, 0f, 0f, 0f);           


            if (hasStarted == false)
            {
                proof51.GetComponent<Animation>().Play("proof9GroupAnim");
                hasStarted = true;
            }
            if (!proof51.GetComponent<Animation>().isPlaying && hasStarted == true)
            {
                appearStart = true;
            }

        }
        else if (appearStart == true && hasStarted == true)
        {
            hasStarted = false;
            appearStart = true;
            previousPosition = proofGroup5.transform.position;
            proofGroup5.transform.position = new Vector3(10000f, 10000f, 10000f);
            proof61.GetComponentInChildren<TextCommands>().enabled = false;
            proof62.GetComponentInChildren<TextCommands>().enabled = false;
            proof63.GetComponentInChildren<TextCommands>().enabled = false;
            proof64.GetComponentInChildren<TextCommands>().enabled = false;
            proof65.GetComponentInChildren<TextCommands>().enabled = false;
            proof66.GetComponentInChildren<TextCommands>().enabled = false;
            proof67.GetComponentInChildren<TextCommands>().enabled = false;
            proofGroup6.transform.position = previousPosition;

        }
        else if (appearStart == true && hasStarted == false)
        {



            if (hasFinished == false)
            {
                proof61.GetComponent<Animation>().Play("proof10GroupAnim");
                hasFinished = true;
            }
            if (!proof61.GetComponent<Animation>().isPlaying && hasFinished == true)
            {
                proof61.GetComponentInChildren<TextCommands>().enabled = true;
                proof62.GetComponentInChildren<TextCommands>().enabled = true;
                proof63.GetComponentInChildren<TextCommands>().enabled = true;
                proof64.GetComponentInChildren<TextCommands>().enabled = true;
                proof65.GetComponentInChildren<TextCommands>().enabled = true;
                proof66.GetComponentInChildren<TextCommands>().enabled = true;
                proof67.GetComponentInChildren<TextCommands>().enabled = true;



                Destroy(proofGroup5);
            }
        }


    }

    void OnSolution()
    {
        if (proofGroup4 == null)
        {
            disappearStart = true;
        }
    }
}