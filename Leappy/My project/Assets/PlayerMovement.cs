using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controllor;
    public Animator animator;
    public Joystick joystick;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crunch = false;

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal >=  .2f)
        {
            horizontalMove = runSpeed;
        }

        else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -runSpeed;
        }

        else
        {
            horizontalMove = 0f;
        }

        float verticalMove = joystick.Vertical;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (verticalMove >= .5f)
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (verticalMove <= -.5f)
        {
            crunch = true;
        }

        else
        {
            crunch = false;
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching (bool IsCrouching)
    {
        animator.SetBool("IsCrouching", IsCrouching);
    }

    void FixedUpdate()
    {
        controllor.Move(horizontalMove * Time.fixedDeltaTime, crunch, jump);
        jump = false;
    }
}
