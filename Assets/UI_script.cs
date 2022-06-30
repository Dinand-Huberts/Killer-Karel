using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_script : MonoBehaviour
{

    public Text Pils_text;
    public int Pils_meter = 100;

    // Start is called before the first frame update
    void Start()
    {


    }


// Update is called once per frame
    void Update()
    {
        Pils_text.text = "bier in je bloed " + Pils_meter;

        if(Input.GetKeyDown(KeyCode.Space)){
            Pils_meter--;
        }

        

    }
}
