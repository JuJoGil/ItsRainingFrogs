using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour
{
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = this.GetComponent<Text>();
        _text.enabled = false;
    }

    public void SetText(GameObject go)
    {
        _text.enabled = true;
        Invoke("TurnOff", 2);
    }
    void TurnOff()
    {
        _text.enabled = false;
    }
}
