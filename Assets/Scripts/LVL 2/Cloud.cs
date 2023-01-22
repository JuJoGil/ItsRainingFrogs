using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cloud : MonoBehaviour
{
    public GameObject cloud, win;
    public float barUpgrade, barDown;
    Vector2 bar;
    public bool finish;
    public Animator anim;

    public float time, timeMax;
    // Start is called before the first frame update
    void Start()
    {
        bar = cloud.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(cloud.transform.localScale.x < 4 && cloud.transform.localScale.x > 0.2f)
        {
            bar.x = bar.x - barDown * Time.deltaTime;
            bar.y = bar.y - (barDown * Time.deltaTime);
            //if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
            //{
            //    bar.x = bar.x + barUpgrade * Time.deltaTime;
            //    bar.y = bar.y + (barUpgrade * Time.deltaTime);
            //}
            cloud.transform.localScale = new Vector2(bar.x, bar.y);
        } else if (cloud.transform.localScale.x >= 4)
        {
            finish = true;
            time = time + Time.deltaTime;
            if(time > timeMax)
            {
                SceneManager.LoadScene("TercerNivel");
            }
            
        }
        else
        {
            SceneManager.LoadScene("Intro");
        }
        anim.SetBool("Finish", finish);


    }

    private void OnMouseDown()
    {
        
        bar.x = bar.x + barUpgrade * Time.deltaTime;
        bar.y = bar.y + (barUpgrade * Time.deltaTime);
        
    }
}
