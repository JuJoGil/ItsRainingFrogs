using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject creditos, puntoCreditos;
    public float restaVelocity;
    
        // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Controller.Singleton.IsFinishing && !Controller.Singleton.IsDead)
        {
            Controller.Singleton.Velocity = Controller.Singleton.Velocity - restaVelocity;
            creditos.transform.position = Vector3.MoveTowards(creditos.transform.position, puntoCreditos.transform.position, Controller.Singleton.Velocity * Time.deltaTime);
        }
        
    }
}
