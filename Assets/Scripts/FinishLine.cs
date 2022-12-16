using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // adding this namespace to start using scene management and changing scenes
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Player")){
            // increase the build index in scene manager to load the next level
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        }
    }
}