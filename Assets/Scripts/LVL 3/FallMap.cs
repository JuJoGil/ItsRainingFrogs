using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallMap : MonoBehaviour
{
    public GameObject creditos, puntoCreditos;
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        creditos.transform.position = Vector3.MoveTowards(creditos.transform.position, puntoCreditos.transform.position, velocity * Time.deltaTime);
    }
}
