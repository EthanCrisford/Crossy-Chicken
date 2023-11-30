using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private bool isHopping;

    public GameObject hopButton;
    public GameObject leftButton;
    public GameObject rightButton;
    [SerializeField] ButtonScript menuButtonScript;
    Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        isHopping = false;

        hopButton = GameObject.Find("HopButton");
        leftButton = GameObject.Find("LeftHopButton");
        rightButton = GameObject.Find("RightHopButton");

        if( hopButton == null )
        {
            print("didn't find button");
        }
        else
        {
            print("found button");
        }
    }

    void Update()
    {
        if (menuButtonScript.hopButtonPressed)
        {
            rb.velocity = new Vector3(0, 5, 2);
            menuButtonScript.hopButtonPressed = false;
            print("do hop - player script");
        }
        
        if (menuButtonScript.leftButtonPressed)
        {
            rb.velocity = new Vector3(-2, 0, 0);
            menuButtonScript.leftButtonPressed = false;
            print("do left - player script");
        }
        
        if (menuButtonScript.rightButtonPressed)
        {
            rb.velocity = new Vector3(2, 0, 0);
            menuButtonScript.rightButtonPressed = false;
            print("do right - player script");
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
