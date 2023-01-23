using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public GameObject player;
    public GameObject pointIzq, pointCen, pointDer;
    public float velocity;
    public bool isMovingIz, isMovingDer, moveCenIz, moveDerCen, moveIzCen, moveCenDer;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Controller.Singleton.Player = player.transform;
        if (isMovingIz == true)
        {
            MovePlayerIz();
        }

        if (isMovingDer == true)
        {
            MovePlayerDer();
        }
    }

    private void LateUpdate()
    {
        player.transform.position = Controller.Singleton.Player.position;
    }

    private void MovePlayerIz()
    {
        if (player.transform.position != pointIzq.transform.position)
        {
            if(player.transform.position == pointCen.transform.position)
            {
                moveCenIz = true;
            } else if (player.transform.position == pointDer.transform.position)
            {
                moveDerCen = true;
            }
        }
        if (moveCenIz)
        {
            player.transform.position = Vector2.MoveTowards(player.transform.position, pointIzq.transform.position, velocity * Time.deltaTime);
            if (player.transform.position == pointIzq.transform.position)
            {
                moveCenIz = false;
                isMovingIz = false;
            }
        }
        if (moveDerCen)
        {
            player.transform.position = Vector2.MoveTowards(player.transform.position, pointCen.transform.position, velocity * Time.deltaTime);
            if (player.transform.position == pointCen.transform.position)
            {
                moveDerCen = false;
                isMovingIz = false;
            }
        }
    }

    private void MovePlayerDer()
    {
        if (player.transform.position != pointDer.transform.position)
        {
            if (player.transform.position == pointCen.transform.position)
            {
                moveCenDer = true;
            }
            else if (player.transform.position == pointIzq.transform.position)
            {
                moveIzCen = true;
            }
        }
        if (moveCenDer)
        {
            player.transform.position = Vector2.MoveTowards(player.transform.position, pointDer.transform.position, velocity * Time.deltaTime);
            if (player.transform.position == pointDer.transform.position)
            {
                moveCenDer = false;
                isMovingDer = false;
            }
        }
        if (moveIzCen)
        {
            player.transform.position = Vector2.MoveTowards(player.transform.position, pointCen.transform.position, velocity * Time.deltaTime);
            if (player.transform.position == pointCen.transform.position)
            {
                moveIzCen = false;
                isMovingDer = false;
            }
        }
    }

    public void ButtonRight()
    {
        if (!isMovingDer && player.transform.position != pointIzq.transform.position)
        {
            isMovingIz = true;
        }
    }

    public void ButtonLeft()
    {
        if (!isMovingIz && player.transform.position != pointDer.transform.position)
        {
            isMovingDer = true;
        }
    }
}
