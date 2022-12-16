using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public static float xRotation = 0f;
    public float rotationSpeed = 0.00001f;

    void FixedUpdate() {
        // rotate enemy objects as they move
        gameObject.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Player")){
            // load the scene again to reset it when player dies
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }
}