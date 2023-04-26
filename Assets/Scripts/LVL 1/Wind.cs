using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public GameObject[] points;
    public GameObject player;
    public float time, timeMax, time2, timeMax2;
    public bool timeController, IzWind, CenWind, DerWind;
    public int n;
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Wind") == 1)
        {
            timeMax = timeMax - 1;
            timeMax2 = timeMax2 - 1;

        }
        timeController = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Controller.Singleton.IsFinishing || Controller.Singleton.IsDead)
        {
            if (timeController)
            {
                time = time + Time.deltaTime;
                if (time >= timeMax)
                {
                    n = Random.Range(1, 4);
                    timeController = false;
                    time = 0;
                }
            }
            else
            {
                if (n == 1)
                {
                    IzWind = true;
                }
                else if (n == 2)
                {
                    CenWind = true;
                }
                else if (n == 3)
                {
                    DerWind = true;
                }
                time2 = time2 + Time.deltaTime;
                if (time2 >= timeMax2)
                {
                    IzWind = false;
                    CenWind = false;
                    DerWind = false;
                    if (player.transform.position == points[n].transform.position)
                    {
                        Controller.Singleton.Velocity = 15;


                    }
                    time2 = 0;
                    timeController = true;
                }

            }

        } else
        {
            IzWind = false;
            CenWind = false;
            DerWind = false;
            n = 0;
        }
        

        anim.SetBool("IzWind", IzWind);
        anim.SetBool("CenWind", CenWind);
        anim.SetBool("DerWind", DerWind);
    }
}
