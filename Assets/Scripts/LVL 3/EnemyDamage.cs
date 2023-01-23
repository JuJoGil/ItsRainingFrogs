using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject life1, life2, life3, point1, point2;
    public bool avanza;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(avanza)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, point2.transform.position, velocity);
            if(this.transform.position.x >= point2.transform.position.x)
            {
                this.transform.rotation = point2.transform.rotation;
                avanza = false;
            }
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, point1.transform.position, velocity);
            if (this.transform.position.x <= point1.transform.position.x)
            {
                this.transform.rotation = point1.transform.rotation;
                avanza = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Controller.Singleton.Life == 3)
        {
            life3.SetActive(false);
        }
        else if (Controller.Singleton.Life == 2)
        {
            life2.SetActive(false);
        }
        else if (Controller.Singleton.Life == 1)
        {
            life1.SetActive(false);
        }
        Controller.Singleton.Life = Controller.Singleton.Life - 1;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
