using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoVelocidad : MonoBehaviour
{
    public int time, rock, bird, clud, wind;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Speed") == 1)
        {
            time = 2;
        }
        else
        {
            time = 1;
        }
        if (PlayerPrefs.GetInt("Rock") == 1)
        {
            rock = 1;
        }
        else
        {
            rock = 0;
        }
        if (PlayerPrefs.GetInt("Bird") == 1)
        {
            bird = 1;
        }
        else
        {
            bird = 0;
        }
        if (PlayerPrefs.GetInt("Cloud") == 1)
        {
            clud = 1;
        }
        else
        {
            clud = 0;
        }
        if (PlayerPrefs.GetInt("Wind") == 1)
        {
            wind = 1;
        }
        else
        {
            wind = 0;
        }

        Time.timeScale = Time.timeScale + 0.5f;
        PlayerPrefs.SetInt("NumeroBucles", (PlayerPrefs.GetInt("NumeroBucles") + 1 + rock + bird + clud + wind)*time);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
