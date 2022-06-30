using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    // Gun Rotation Function
    public float offset;
    private SpriteRenderer spriteRender;


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
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        
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
       
       
       Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
       diff.Normalize();
 
       float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
       transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 0);
    }
}
