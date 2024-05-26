using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardspeed;

    private int desiredLane = 1;//0;left 1;middle 2;right
    public float laneDistance = 4;

    public float jumpForce;
    public float Gravity = -20;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

 
    void Update()
    {
        direction.z = forwardspeed;

        direction.y += Gravity * Time.fixedDeltaTime;
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {

            Jump();

        }
    }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;

        }
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;

        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        
    
            }
        transform.position = Vector3.Lerp(transform.position, targetPosition,80*Time.fixedDeltaTime);
}

private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }
    private void Jump()
    {
        direction.y = jumpForce;
    }
}
