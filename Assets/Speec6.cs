using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speec6 : MonoBehaviour
{
    public GameObject proofGroup5;

    public SpriteRenderer proof61;
    public SpriteRenderer proof62;
    public SpriteRenderer proof63;
    public SpriteRenderer proof64;
    public SpriteRenderer proof65;
    public SpriteRenderer proof66;
    public SpriteRenderer proof67;
    public GameObject proofGroup6;
    public Vector3 previousPosition;
    public SpriteRenderer proof71;
    public GameObject proofGroup7;
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

        proof71.color = new Color(255f, 255f, 255f, 0f);
       

    }

    // Update is called once per frame
    void Update()
    {
        if (disappearStart == true && appearStart == false)
        {
            proof62.color = new Color(0f, 0f, 0f, 0f);
            proof63.color = new Color(0f, 0f, 0f, 0f);
            proof64.color = new Color(0f, 0f, 0f, 0f);
            proof65.color = new Color(0f, 0f, 0f, 0f);
            proof66.color = new Color(0f, 0f, 0f, 0f);
            proof67.color = new Color(0f, 0f, 0f, 0f);


            if (hasStarted == false)
            {
                proof61.GetComponent<Animation>().Play("proof11GroupAnim");
                hasStarted = true;
            }
            if (!proof61.GetComponent<Animation>().isPlaying && hasStarted == true)
            {
                appearStart = true;
            }

        }
        else if (appearStart == true && hasStarted == true)
        {
            hasStarted = false;
            appearStart = true;
            previousPosition = proofGroup6.transform.position;
            proofGroup6.transform.position = new Vector3(10000f, 10000f, 10000f);
            proof71.GetComponentInChildren<TextCommands>().enabled = false;
            proofGroup7.transform.position = previousPosition;

        }
        else if (appearStart == true && hasStarted == false)
        {



            if (hasFinished == false)
            {
                proof71.GetComponent<Animation>().Play("proof12GroupAnim");
                //proof71.color = new Color(255f, 255f, 255f, 255f);

                hasFinished = true;
            }
            if (!proof71.GetComponent<Animation>().isPlaying && hasFinished == true)
            {
                proof71.GetComponentInChildren<TextCommands>().enabled = true;




                Destroy(proofGroup6);
            }
        }


    }

    void OnSolution()
    {
        if (proofGroup5 == null)
        {
            disappearStart = true;
        }
    }
}