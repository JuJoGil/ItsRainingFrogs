using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public GameObject text, point;
    public float velocity;
    

    public float time, timeMax;

    
    // Start is called before the first frame update
    void Start()
    {
        Controller.Singleton.IsDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.Singleton.IsDead)
        {
            Controller.Singleton.Player.position = Vector2.MoveTowards(Controller.Singleton.Player.position, point.transform.position, velocity * Time.deltaTime);
            //camara.transform.position = Vector2.MoveTowards(camara.transform.position, pointCamera.transform.position, velocity * Time.deltaTime);
            time = time + Time.deltaTime;
            if (time >= timeMax)
            {
                SceneManager.LoadScene("Intro");
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Controller.Singleton.IsDead = true;
    }
}
