using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinGame : MonoBehaviour
{
    public GameObject winText, point, camara, pointCamera;
    public float velocity, time, timeMax;
    Scene currentScene;
    string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        Controller.Singleton.IsFinishing = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Controller.Singleton.IsFinishing)
        {
            Controller.Singleton.Player.position = Vector2.MoveTowards(Controller.Singleton.Player.position, point.transform.position, velocity * Time.deltaTime);
            if (sceneName == "PrimerNivel")
            {
                if (Controller.Singleton.Player.position == point.transform.position)
                {
                    SceneManager.LoadScene("SegundoNivel");
                }
            } else if (sceneName == "TercerNivel")
            {
                time = time + Time.deltaTime;
                if (time >= timeMax)
                {
                    SceneManager.LoadScene("CuartoNivel");
                }
            }

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Controller.Singleton.IsFinishing = true;

    }
}
