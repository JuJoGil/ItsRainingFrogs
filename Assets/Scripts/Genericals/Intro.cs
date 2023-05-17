using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public float time, timeMax;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Speed") == 1)
        {
            Time.timeScale = Time.timeScale + 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= timeMax)
        {
            SceneManager.LoadScene("Intro");
        }
    }
}
