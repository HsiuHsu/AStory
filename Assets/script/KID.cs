using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KID : MonoBehaviour {

    public bool ZoomingOut = false;
    public bool ZoomingOut2 = false;


    public Animator anim;

    public GameObject UI1;

    public GameObject ob1;


    // Use this for initialization
    void Start()
    {
        ob1.SetActive(false);
        UI1.SetActive(false);
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dad")
        {
            ob1.SetActive(true);
            ZoomingOut = true;

        }

        else if (other.gameObject.tag ==  "qcollider")
        {
            ZoomingOut2 = true;
        }

        if(ZoomingOut == true && ZoomingOut2 == true)
        {
            UI1.SetActive(true);
        }
    }

    private IEnumerator ActivationRoutine()
    {
        yield return new WaitForSeconds(10);

        UI1.SetActive(false);
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "dad")
        {
            anim.Play("kidstand");
        }

        else if (other.gameObject.tag == "qcollider")
        {
            UI1.SetActive(false);
        }

    }


    
    // Update is called once per frame
    void Update()
    {

    }



}
