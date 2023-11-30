using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private bool isHopping;

    public GameObject hopButton;
    ButtonScript menuButtonScript;
    Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        isHopping = false;

        hopButton = GameObject.Find("HopButton");

        if( hopButton == null )
        {
            print("didn't find button");
        }
        else
        {
            print("found button");
        }

        


    }

    private void Update()
    {
        menuButtonScript = hopButton.GetComponent<ButtonScript>();

        if ( menuButtonScript.hopButtonPressed)
        {
            print("do hop - player script");
            rb.velocity = new Vector3(0, 5, 2);
            menuButtonScript.hopButtonPressed = false;
        }

        return;

        print("touches=" + Input.touchCount);

        if (Input.touchCount > 0 && !isHopping)
        {
            Touch touch = Input.GetTouch(0);
            animator.SetTrigger("Hop");
            isHopping = true;
            float zDifference = 0;

            if (transform.position.z % 1 != 0)
            {
                Debug.Log("On Grid Space");
                zDifference = Mathf.Round(transform.position.z) - transform.position.z;
            }
            transform.position = (transform.position + new Vector3(1, 0, zDifference));
        }
        else if (Input.GetKeyDown(KeyCode.A) && !isHopping)
        {
            animator.SetTrigger("hop");
            isHopping = true;
            transform.position = (transform.position + new Vector3(0, 0, 1));
        }
        else if (Input.GetKeyDown(KeyCode.D) && !isHopping)
        {
            animator.SetTrigger("hop");
            isHopping = true;
            transform.position = (transform.position + new Vector3(0, 0, -1));
        }
    }

    public void FinishHop()
    {
        isHopping = false;
    }

}
