using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject hopButton;
    public GameObject leftButton;
    public GameObject rightButton;
    [SerializeField] ButtonScript menuButtonScript;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        hopButton = GameObject.Find("HopButton");
        leftButton = GameObject.Find("LeftHopButton");
        rightButton = GameObject.Find("RightHopButton");

        if (hopButton == null)
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
            rb.velocity = new Vector3(0, 5, 1.5f);
            menuButtonScript.hopButtonPressed = false;
        }

        if (menuButtonScript.leftButtonPressed)
        {
            rb.velocity = new Vector3(-2, 0, 0);
            menuButtonScript.leftButtonPressed = false;
        }

        if (menuButtonScript.rightButtonPressed)
        {
            rb.velocity = new Vector3(2, 0, 0);
            menuButtonScript.rightButtonPressed = false;
        }
    }
}