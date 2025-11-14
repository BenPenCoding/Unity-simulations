using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float mass = 1f;
    public bool directionUp;
    public bool directionRight;
    public float velocity = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        directionUp = true;
        directionRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (directionUp){
            transform.Translate(Vector2.up*velocity*Time.deltaTime);
        }
        else {
            transform.Translate(-Vector2.up*velocity*Time.deltaTime);
        }
    
        if (directionRight){
            transform.Translate(Vector2.right*velocity*Time.deltaTime);
        }
        else {
            transform.Translate(-Vector2.right*velocity*Time.deltaTime);
        } 
       
        if (Math.Abs(transform.position.y) > 4.4){
            directionUp = !directionUp;
        } //Up/down

        if (Math.Abs(transform.position.x) > 8.4){
            directionRight = !directionRight;
        } //Left/right
    
        velocity *= 1.0001f;

    }
    

}
