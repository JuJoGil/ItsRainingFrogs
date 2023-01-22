using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameObject winText, point, camara, pointCamera;
    public float velocity;
    public bool isFinishing;

    public static WinGame instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isFinishing)
        {
            MoveCharacter.instance.player.transform.position = Vector2.MoveTowards(MoveCharacter.instance.player.transform.position, point.transform.position, velocity * Time.deltaTime);
            //camara.transform.position = Vector2.MoveTowards(camara.transform.position, pointCamera.transform.position, velocity * Time.deltaTime);
            if (MoveCharacter.instance.player.transform.position == point.transform.position)
            {
                SceneManager.LoadScene("SegundoNivel");
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        isFinishing = true;

    }
}
