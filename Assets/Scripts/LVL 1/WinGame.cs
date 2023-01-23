using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameObject winText, point, camara, pointCamera;
    public float velocity;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Controller.Singleton.IsFinishing)
        {
            Controller.Singleton.Player.position = Vector2.MoveTowards(Controller.Singleton.Player.position, point.transform.position, velocity * Time.deltaTime);
            //camara.transform.position = Vector2.MoveTowards(camara.transform.position, pointCamera.transform.position, velocity * Time.deltaTime);
            if (Controller.Singleton.Player.position == point.transform.position)
            {
                SceneManager.LoadScene("SegundoNivel");
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Controller.Singleton.IsFinishing = true;

    }
}
