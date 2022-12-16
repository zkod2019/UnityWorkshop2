using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] GameObject[] pointsLocation;
    int currentLocationIndex = 0;
    [SerializeField] float speed =1f;

    // Update is called once per frame
    void Update()
    {
        // we check how far we are from the currently active way point. if we touch it we switch to the next one
        if (Vector3.Distance(transform.position, pointsLocation[currentLocationIndex].transform.position) < .1f){
            currentLocationIndex++;
            if(currentLocationIndex >= pointsLocation.Length){
                currentLocationIndex =0;
            }
        }
        // MoveTowards calculate a new position between two game objects (between platforms current position and the points its going towards)
        // MoveTowards(current position, position moving towards (accessed through pointsLocation array), speed )
        transform.position = Vector3.MoveTowards(transform.position, pointsLocation[currentLocationIndex].transform.position, speed * Time.deltaTime );
        
    }
}
