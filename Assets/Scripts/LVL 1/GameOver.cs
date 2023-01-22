using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool isDead;
    public GameObject text, point;
    public float velocity;
    public static GameOver instance;

    public float time, timeMax;

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
        if (isDead)
        {
            MoveCharacter.instance.player.transform.position = Vector2.MoveTowards(MoveCharacter.instance.player.transform.position, point.transform.position, velocity * Time.deltaTime);
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
        isDead = true;
    }
}
