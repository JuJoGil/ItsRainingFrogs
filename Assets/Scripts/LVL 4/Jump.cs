using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    public Event youWin;
    Rigidbody2D _rb;
    public float power, time, timeMax, time2, timeMax2;
    public Vector3 inicial;
    public GameObject player;
    public bool onAir, finish;
    SpriteRenderer _sr;
    public Sprite[] skins;
    public GameObject life1, life2, life3;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
        Controller.Singleton.StopRock = false;

        _sr.sprite = skins[PlayerPrefs.GetInt("Skin")];
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.Singleton.Life == 2)
        {
            life3.SetActive(false);
        }
        else if (Controller.Singleton.Life == 1)
        {
            life3.SetActive(false);
            life2.SetActive(false);
        }

        time = time + Time.deltaTime;
        if (time >= timeMax)
        {
            Controller.Singleton.StopRock = true;
            time2 = time2 + Time.deltaTime;
            if (!finish)
            {
                youWin.Ocurred(this.gameObject);
                finish = true;
            }
            
            if (time2 >= timeMax2)
            {
                SceneManager.LoadScene("CinematicBucle");
            }
            

        }
        if (player.transform.position == inicial)
        {
            onAir = false;
        }
        else
        {
            onAir = true;
        }

        anim.SetBool("onAir", onAir);
        anim.SetInteger("Skin", PlayerPrefs.GetInt("Skin"));
    }

    public void JumpFrog()
    {
        if (!onAir)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, power);
        }
        
    }
}
