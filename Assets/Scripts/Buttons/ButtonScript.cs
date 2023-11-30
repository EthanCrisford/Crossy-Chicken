using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public bool hopButtonPressed;
    public bool leftButtonPressed;
    public bool rightButtonPressed;

    public void DoHop()
    {
        hopButtonPressed = true;
    }

    public void LeftHop()
    {
        leftButtonPressed = true;
    }

    public void RightHop()
    {
        rightButtonPressed = true;
    }
}
