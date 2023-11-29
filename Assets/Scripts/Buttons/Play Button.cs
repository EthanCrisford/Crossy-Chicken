using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    void Start()
    {
        Play();
    }

    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
