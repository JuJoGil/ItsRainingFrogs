using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Controller
{
    //Controlador y acceso a la vida del personaje
    private float _life;
    public float Life
    {
        get { return _life; }
        set { _life = value; }
    }

    //Controlador y acceso para ver si el jugador a muerto
    private bool _isDead;
    public bool IsDead
    {
        get { return _isDead; }
        set { _isDead = value; }
    }

    //Controlador y acceso para ver si el jugador a acabado un movimiento
    private bool _isFinishing;
    public bool IsFinishing
    {
        get { return _isFinishing; }
        set { _isFinishing = value; }
    }

    //Controlador y acceso a la velocidad del jugador
    private float _velocity;
    public float Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }

    //Controlador y acceso a la variable Transform del jugador
    private Transform _player;
    public Transform Player
    {
        get { return _player; }
        set { _player = value; }
    }

    //Controlador y acceso para detener la roca
    private bool _stopRock;
    public bool StopRock
    {
        get { return _stopRock; }
        set { _stopRock = value; }
    }

    private int _bucles;
    public int Bucles
    {
        get { return _bucles; }
        set { _bucles = value; }
    }

    private string _skin;
    public string Skin
    {
        get { return _skin; }
        set { _skin = value; }
    }

    //Creamos una referencia estática que apunta al Singleton
    private static Controller instance;


    //Accesor a la instancia del Singleton
    public static Controller Singleton
    {
        //El get nos sirve para obtener la información del Singleton
        get
        {
            //Comprobamos primero que la instancia esté vacía
            if (instance == null)
            {
                //Rellenamos la referencia del Singleton
                instance = new Controller();

            }
            //Nos devuelve la información de la instancia
            return instance;
        }
    }
}
