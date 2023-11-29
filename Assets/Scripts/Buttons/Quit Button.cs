using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class QuitButton : MonoBehaviour
{
    void Start()
    {
        Quit();
    }

    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
