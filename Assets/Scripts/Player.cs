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

            Debug.Log(transform.position);

            if (transform.position.z % 1 == 0)
            {
                Debug.Log("On Grid Space");
                transform.Translate(new Vector3(1, 0, 0));
            }
        }
    }

    public void FinishHop()
    {
        isHopping = false;
    }
}
