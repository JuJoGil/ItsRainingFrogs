using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("InitialCinematic");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Intro");
    }

    public void SkipCinematic()
    {
        SceneManager.LoadScene("PrimerNivel");
    }
}
