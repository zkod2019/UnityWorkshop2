using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; // speed of player (value set in Inspector)
    private Rigidbody rb;
    public float jump; // height of jump (value set in Inspector)
    public bool isJumping; // check to see if player is on the floor to let them jump
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(speed * x, rb.velocity.y, speed * z); // Vector(x, y)


        if (Input.GetButtonDown("Jump") && isJumping == false){ // if space is pressed and player isn't already jumping
            rb.AddForce(new Vector3(rb.velocity.x, jump, rb.velocity.z));
            Debug.Log("Player is jumping");
        }
    }

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Floor")){
            isJumping = false;
        }
    }

    private void OnCollisionExit(Collision other){
        if (other.gameObject.CompareTag("Floor")){
            isJumping = true;
        }
    }
}