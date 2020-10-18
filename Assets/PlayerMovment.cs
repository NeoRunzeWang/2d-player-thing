using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    
        public CharacterController2D controller;
        public float runningSpeed = 40f;
    // Start is called before the first frame update
        float horizontalMove = 0f;
        bool Jump = false;
        bool crouch = false;
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runningSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            Jump = true;
        }   
        if(Input.GetButtonDown("Crouchs"))
        {
            crouch = true;
        }   else if (Input.GetButtonUp("Crouchs"))
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {

            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, Jump);
            Jump = false;
            
            

    }
}
