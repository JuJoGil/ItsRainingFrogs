using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        Controller.Singleton.Life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.Singleton.Life <= 0)
        {
            SceneManager.LoadScene("Intro");
        }
    }

    
}
