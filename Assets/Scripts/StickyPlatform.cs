using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == "Player"){ //if we are colliding with the player we want to make it the child of the platform
            collision.gameObject.transform.SetParent(transform);
        }
    }
    // when player exits the platform, he will no longer be a child of that platform
    void OnCollisionExit(Collision collision){
        if (collision.gameObject.name == "Player"){ 
            collision.gameObject.transform.SetParent(null);
        }
    }
}
