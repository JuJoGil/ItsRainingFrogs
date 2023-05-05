using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDamage : MonoBehaviour
{
    public GameObject point;
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
        
        Controller.Singleton.Life = Controller.Singleton.Life - 1;

    }

    
}
