using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject asteroid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 1)
        {
            //Instantiate(asteroid, this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0), Quaternion.identity);
            GameObject a = Pool.singleton.Get("Asteroid");
            if(a != null)
            {
                a.transform.position = this.transform.position;
                var aux = a.GetComponent<RockDamage>();
                aux.life1 = GameObject.Find("Life");
                aux.life2 = GameObject.Find("Life2");
                aux.life3 = GameObject.Find("Life3");

                a.SetActive(true);
            }
            
        }

    }
}
