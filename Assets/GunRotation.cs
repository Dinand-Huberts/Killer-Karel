using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    // Gun Rotation Function
    public float offset;
    private SpriteRenderer spriteRender;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        // Gun Rotation Function
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        
        if (rotZ < 89 && rotZ > -89)
        {
            // Debug.Log("Facing right");
            spriteRender.flipY = false;
        }
        else
        {
            // Debug.Log("Facing left");
            spriteRender.flipY = true;
        }
       

    }
}
