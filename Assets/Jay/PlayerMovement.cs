using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    // public Transform wallGrabPoint; TODO: Error fixen
    public LayerMask whatisWall;
    private bool canGrab, isGrabbing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        //Walljump
        // canGrab = Physics2D.OverlapCircle(wallGrabPoint.position, 2f, whatisWall); TODO

        if(canGrab)
        {
            if((transform.localScale.x == 1f && Input.GetAxisRaw("Horizontal") > 0) || (transform.localScale.x == 1f && Input.GetAxisRaw("Horizontal") > 0))
            {
                isGrabbing = true;
            }
        }

        if(isGrabbing)
        {
//            theRB.gravityScale = 0f;
        }

    }

    void FixedUpdate()
    {
        //Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
