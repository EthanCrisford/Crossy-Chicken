using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isGrounded;
    public GameObject hopButton;
    public GameObject leftButton;
    public GameObject rightButton;
    [SerializeField] ButtonScript menuButtonScript;
    Rigidbody rb;
    public Transform rayMarker;
    public float rayDistance = 0.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
        hopButton = GameObject.Find("HopButton");
        leftButton = GameObject.Find("LeftHopButton");
        rightButton = GameObject.Find("RightHopButton");
    }

    void Update()
    {
        Debug.Log("grounded is" + isGrounded);
        GroundCheck();
        Debug.DrawRay(rayMarker.position, -rayMarker.up  * rayDistance);

        if (menuButtonScript.hopButtonPressed && isGrounded)
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

    void GroundCheck()
    {
        Physics.Raycast(rayMarker.position, -Vector3.up, out RaycastHit hitinfo, rayDistance);

        if (hitinfo.collider.gameObject.tag == "Ground")
        {
            isGrounded = true;
            Debug.Log("Collided with " + hitinfo.collider.name);
        }
        else
        {
            isGrounded = false;
            Debug.Log("NOT GROUNDED!");
        }
    }
}