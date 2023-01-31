using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumeroBucles : MonoBehaviour
{
    public Text buclesText;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        buclesText.text = ": " + PlayerPrefs.GetInt("NumeroBucles");
    }
}
