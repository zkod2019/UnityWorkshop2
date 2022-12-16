using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
 using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    public Text scoreText;
    public GameObject Player;
    public static float xRotation = 0f;
    public float rotationSpeed = 0.00001f;

    void FixedUpdate() {
        gameObject.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount =0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
    }

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Player")){
            // retrive the ScoreText component
            scoreText = GameObject.Find("ScoreText").GetComponent<Text>(); 
            Debug.Log(scoreText);
            // increase score by one everytime a point it gained
            scoreAmount = scoreAmount + 1;
            // update score count
            scoreText.text =  "Score: " + scoreAmount.ToString();
            // hide the award object so it can't be recollected in the same round
            gameObject.SetActive(false);
            
        }
    }
}