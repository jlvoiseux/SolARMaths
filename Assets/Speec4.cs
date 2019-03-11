using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speec4 : MonoBehaviour
{
    public GameObject proofGroup3;

    public SpriteRenderer proof41;
    public SpriteRenderer proof42;
    public SpriteRenderer proof43;
    public SpriteRenderer proof44;
    public SpriteRenderer proof45;
    public GameObject proofGroup4;
    public Vector3 previousPosition;
    public SpriteRenderer proof51;
    public SpriteRenderer proof52;
    public GameObject proofGroup5;
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

        proof51.color = new Color(255f, 255f, 255f, 0f);
        proof52.color = new Color(0f, 0f, 0f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disappearStart == true && appearStart == false)
        {
            proof42.color = new Color(0f, 0f, 0f, 0f);
            proof43.color = new Color(0f, 0f, 0f, 0f);
            proof44.color = new Color(0f, 0f, 0f, 0f);
            proof45.color = new Color(0f, 0f, 0f, 0f);


            if (hasStarted == false)
            {
                proof41.GetComponent<Animation>().Play("proof7GroupAnim");
                hasStarted = true;
            }
            if (!proof41.GetComponent<Animation>().isPlaying && hasStarted == true)
            {
                appearStart = true;
            }

        }
        else if (appearStart == true && hasStarted == true)
        {
            hasStarted = false;
            appearStart = true;
            previousPosition = proofGroup4.transform.position;
            proofGroup4.transform.position = new Vector3(10000f, 10000f, 10000f);
            proof51.GetComponentInChildren<TextCommands>().enabled = false;
            proof52.GetComponentInChildren<TextCommands>().enabled = false;            
            proofGroup5.transform.position = previousPosition;

        }
        else if (appearStart == true && hasStarted == false)
        {



            if (hasFinished == false)
            {
                proof51.GetComponent<Animation>().Play("proof8GroupAnim");
                hasFinished = true;
            }
            if (!proof51.GetComponent<Animation>().isPlaying && hasFinished == true)
            {
                proof51.GetComponentInChildren<TextCommands>().enabled = true;
                proof52.GetComponentInChildren<TextCommands>().enabled = true;
                


                Destroy(proofGroup4);
            }
        }


    }

    void OnSolution()
    {
        if (proofGroup3 == null)
        {
            disappearStart = true;
        }
    }
}