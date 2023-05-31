using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarNumero : MonoBehaviour
{
    public Text valor;
    // Start is called before the first frame update
    void Start()
    {
        
        valor.text = DataBaseManager.LoadValue1().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
