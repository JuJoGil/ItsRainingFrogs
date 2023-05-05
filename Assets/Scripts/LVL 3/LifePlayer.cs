using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    Scene currentscene;
    
    // Start is called before the first frame update
    void Start()
    {
        currentscene = SceneManager.GetActiveScene();
        if(currentscene.name == "TercerNivel")
        {
            Controller.Singleton.Life = 3;
        }
        
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
