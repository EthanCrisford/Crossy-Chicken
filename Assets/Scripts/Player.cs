using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private bool isHopping;

    void Start()
    {
        animator = GetComponent<Animator>();
        isHopping = false;
    }

    private void Update()
    {
        Debug.Log(isHopping);

        if (Input.GetKeyDown(KeyCode.Space) && !isHopping)
        {
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
