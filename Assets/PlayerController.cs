using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    //[SerializeField] ParticleSystem DriftEffect; //was not working
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool canMove = true;
    void Start()
    {
        // VARIABLES:
        rb2d = GetComponent<Rigidbody2D>();
        // REFERENCE TO ANOTHER GAME OBJECT(S):
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>(); 
        //(Components usually are a type as well!):
    }
    void Update()
    {   
        if(canMove)
        {
            // METHODS (ctrl dot -> extract method/ generate method):
            RotatePlayer();
            RespondToBoost();
        }
    }
    public void DisableControls()
    {
        canMove = false;   
    }
    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
            //DriftEffect.Play(); //was not working
        }
        else 
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}