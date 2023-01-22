using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject creditos, puntoCreditos;
    public float velocity, restaVelocity;
    public static MoveMap instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

        // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!WinGame.instance.isFinishing && !GameOver.instance.isDead)
        {
            velocity = velocity - restaVelocity;
            creditos.transform.position = Vector3.MoveTowards(creditos.transform.position, puntoCreditos.transform.position, velocity * Time.deltaTime);
        }
        
    }
}
