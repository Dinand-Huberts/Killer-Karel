using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    float scaleX;

    public float offset;
    public int last = 0; 
    


    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log(scaleX);
    }


    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.mousePosition.x < Screen.width / 2f && last == 1)
        {   
            last = 0;
            Debug.Log("links");
            transform.localScale = new Vector3(180, transform.localScale.y, transform.localScale.z);
        }
        else if (Input.mousePosition.x > Screen.width / 2f && last == 0)
        {
            last = 1;
            Debug.Log("rechts");
            transform.localScale = new Vector3(0, transform.localScale.y, transform.localScale.z);
        }
    }
}