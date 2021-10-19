using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageD : MonoBehaviour {

    public Animator anim;
    public Animator anim2;

    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ImageC")
        {
            anim2.Play("");
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
