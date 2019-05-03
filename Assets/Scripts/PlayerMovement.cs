using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Animator PlayerController;
    float speed = 10.0f;
    public Rigidbody playerRB;

    // This is a reference to the Rigidbody component called "rb"

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void Start()
    {

        playerRB = GetComponent<Rigidbody>();

        PlayerController = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        //Walk Animation Zombie
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow)
             || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Animate Walk
            PlayerController.SetTrigger("Walk");

        }

        //Stop Zombie Animation
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow)
             || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            PlayerController.SetTrigger("Idle");
        }



    }


    void FixedUpdate()
    {
        //Move Code

        //Move Player Forward
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, 5), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        //Move Player Back
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, -5), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.back);

        }

        //Move Player Left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Move Player
            playerRB.AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.left);
        }

        //Move Player Right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Move Player
            playerRB.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.right);
        }
    }



}
