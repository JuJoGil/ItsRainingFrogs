using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicCounter : MonoBehaviour
{
    public float time, timeMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time >= timeMax)
        {
            SceneManager.LoadScene("PrimerNivel");
        }
    }
}
