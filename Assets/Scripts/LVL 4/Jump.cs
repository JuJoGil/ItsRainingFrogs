using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    Rigidbody2D _rb;
    public float power, time, timeMax;
    public Vector3 inicial;
    public GameObject player;
    public bool onAir;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= timeMax)
        {
            SceneManager.LoadScene("Intro");
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
    }

    public void JumpFrog()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, power);
    }
}
