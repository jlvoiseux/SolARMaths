using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speec : MonoBehaviour {

    public SpriteRenderer enonce;
    public SpriteRenderer enonce1;
    public SpriteRenderer enonce2;
    public GameObject enonceGroup;
    public Vector3 previousPosition;
    public SpriteRenderer proof11;
    public SpriteRenderer proof12;
    public GameObject proofGroup1;
    public bool disappearStart = false;
    public bool appearStart = false;
    public float fadeSpeed = 1f;
    public float fadeTime = 0.25f;
    public float Fade;
    public bool hasStarted = false;
    public bool hasFinished= false;


    // Use this for initialization
    void Start () {
        Fade = 255f;
        previousPosition = enonceGroup.transform.position;
        proof11.color = new Color(255f, 255f, 255f, 0f);
        proof12.color = new Color(0f, 0f, 0f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (disappearStart == true && appearStart == false)
        {
            enonce1.color = new Color(0f, 0f, 0f, 0f);
            enonce2.color = new Color(0f, 0f, 0f, 0f);

            if (hasStarted == false)
            {
                enonce.GetComponent<Animation>().Play("enonceGroupAnim");
                hasStarted = true;
            }
            if (!enonce.GetComponent<Animation>().isPlaying && hasStarted == true)
            {
                appearStart = true;
            }

        }
        else if (appearStart == true && hasStarted == true)
        {
            hasStarted = false;
            appearStart = true;
            enonceGroup.transform.position = new Vector3(10000f, 10000f, 10000f);
            proof11.GetComponentInChildren<TextCommands>().enabled = false;
            proof12.GetComponentInChildren<TextCommands>().enabled = false;
            proofGroup1.transform.position = previousPosition;

        }
        else if (appearStart == true && hasStarted == false)
        {
            
            

            if (hasFinished == false)
            {
                //proof11.GetComponent<Animation>().Play("proofGroupAnim");
                hasFinished = true;
            }
            if (!enonce.GetComponent<Animation>().isPlaying && hasFinished == true)
            {
                proof11.GetComponentInChildren<TextCommands>().enabled = true;
                proof12.GetComponentInChildren<TextCommands>().enabled = true;
                Destroy(enonceGroup);
            }
        }

                   
    }

    void OnSolution()
    {
        disappearStart = true;
    }
}
