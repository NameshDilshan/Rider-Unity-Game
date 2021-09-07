using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    bool move = false;
    bool isGrounded = false;

    public Rigidbody2D rb;
    public float speed = 20f;
    public float rotationSpeed = 7f;


    //update used for getting input
    //called frame by frame. so, Quick
    private void Update(){
        if(Input.GetButtonDown("Fire1")){
            Debug.Log("working down");
            move = true;
        }
        if(Input.GetButtonUp("Fire1")){
            move = false;
        }
    }

    //fixedupdate used for controlling the car 
    //called fixed amount of times.
    private void FixedUpdate(){

        if(move == true){
            if(isGrounded){
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f , ForceMode2D.Force);
            }else{
                rb.AddTorque(rotationSpeed * Time.fixedDeltaTime * 100f , ForceMode2D.Force);
            }
            
        }
    }

    private void OnCollisionEnter2D(){
        isGrounded = true;
    } 

    private void OnCollisionExit2D(){
        isGrounded = false;
    }
}
