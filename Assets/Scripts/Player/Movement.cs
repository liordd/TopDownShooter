using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInfo : MonoBehaviour
{
    protected float moveInputHorizontal;
    protected float moveInputVertical;
    public float playerSpeed = 10f;

    protected Animator animPlayer;
    protected Rigidbody rigidBody;

    public Joystick joystick;
}

public class Movement : MovementInfo
{


    void Start()
    {

        rigidBody = GetComponent<Rigidbody>();
        animPlayer = GetComponent<Animator>();

    }

    void FixedUpdate()
    {

        Walk();

    }


    public void Walk()
    {
        moveInputHorizontal = joystick.Horizontal;
        moveInputVertical = joystick.Vertical;


        Vector3 movement = new Vector3(moveInputHorizontal * playerSpeed, 0, moveInputVertical * playerSpeed);
        rigidBody.velocity = movement;

        animPlayer.SetFloat("IsRunning", Mathf.Abs(moveInputHorizontal) + Mathf.Abs(moveInputVertical));
    }





}
