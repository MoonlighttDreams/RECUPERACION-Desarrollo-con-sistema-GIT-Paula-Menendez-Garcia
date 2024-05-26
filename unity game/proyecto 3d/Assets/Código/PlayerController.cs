using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;
using static System.Runtime.CompilerServices.RuntimeHelpers;


public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardspeed;
    public static bool GameStarted;
    public float maxSpeed;

    private int desiredLane = 1;
    public float laneDistance = 4;

    public float jumpForce;
    public float Gravity = -2;

    public Animator animator;
    private bool isGrounded;
    private bool isSliding;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        GameStarted = false;
        isGrounded = true;
        isSliding = false;
    }




    void Update()
    {
        if (!Panelgameover.GameStarted)
            return;
        //Aumento Velocidad
        if(forwardspeed < maxSpeed)
        forwardspeed += 0.1f * Time.deltaTime;

        animator.SetBool("GameStarted", true);
        animator.SetBool("isGrounded", isGrounded);

        direction.z = forwardspeed;
        direction.y += Gravity * Time.fixedDeltaTime;


        // check grouded //
        if (controller.isGrounded)
        {
            // saltar
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
                isGrounded = false;
            }
        }
        // y si no, grounded otra vez //
        else if (controller.isGrounded == false)
        {
            isGrounded = true;
        }

        // izquierda, derecha //
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

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(Slide()); 
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

        transform.position = Vector3.Lerp(transform.position, targetPosition, 80 * Time.fixedDeltaTime);
        controller.center = controller.center;
    }

    // panel game over //
    private void FixedUpdate()
    {
        if (!Panelgameover.GameStarted)
            return;

        controller.Move(direction * Time.fixedDeltaTime);
    }
    private void Jump()
    {
        direction.y = jumpForce;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstaculo")
        {
           
           
        }
    }
    //Deslizar
    private IEnumerator Slide()
    {
        isSliding = true;
        animator.SetBool("isSliding",true);
        controller.center =new Vector3 (0, -0.5f, 0);
        controller.height = 1;
        yield return new WaitForSeconds(1f);
        controller.center = new Vector3(0, 0f, 0);
        controller.height = 2;

        animator.SetBool("isSliding", false);
        isSliding = false;



    }
}

