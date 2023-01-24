using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDamage : MonoBehaviour
{
    public GameObject life1, life2, life3, point;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!Controller.Singleton.StopRock)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, point.transform.position, velocity * Time.deltaTime);
        } else
        {
            this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }
        
        if (this.transform.position.x <= point.transform.position.x)
        {
            this.gameObject.SetActive(false);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
        if (Controller.Singleton.Life == 3)
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

    }

    
}
