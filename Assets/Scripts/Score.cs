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
        //scoreText = GetComponent<Text>;
        scoreAmount =0;
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
        
    }

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Player")){
            scoreText=GameObject.Find("ScoreText").GetComponent<Text>(); 
            Debug.Log(scoreText);
            scoreAmount = scoreAmount + 1;
            scoreText.text =  "Score: " + scoreAmount.ToString();
            gameObject.SetActive(false);
            
        }
    }
}