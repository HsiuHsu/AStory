using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hidad : MonoBehaviour {

    
    public bool activeInHierarchy;

    public GameObject ob1;

    // Use this for initialization
    void Start () {

        ob1.SetActive(false);

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dad")
        {
            ob1.SetActive(true);

        }

    }

    // Update is called once per frame
    void Update () {

    }
}
