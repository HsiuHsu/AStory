using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DAD : MonoBehaviour {

    public Animator anim;

    public bool ZoomingOut = false;

    public Button bt1;

    // Use this for initialization
    void Start()
    {
        bt1.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        throw new NotImplementedException();
        ZoomingOut = true;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "school")
        {
           
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "girl")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ZoomingOut == true)
        {
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        anim.Play("shakehand");
    }
}
