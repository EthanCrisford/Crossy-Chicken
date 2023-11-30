using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
