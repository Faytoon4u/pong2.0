using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class ball : MonoBehaviour
{
    public KeyCode keySpace = KeyCode.Space;
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xspeed = 1f;
    public float yspeed = 1f;
    public bool scored = false;
    public int randomSpeed;
    public int leftscore = 0;
    public int rightscore = 0;
    public int winscore = 0;
    public TMP_Text scoreText;
        

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
        randomSpeed = UnityEngine.Random.Range(5,10);
    }

    // Update is called once per frame
    void Update()
    {
      
        if (!scored)
        {
            xPosition = xPosition + xspeed * Time.deltaTime * (3 + randomSpeed);
            yPosition = yPosition + yspeed * Time.deltaTime * (3 + randomSpeed);
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            scored = false;
        }

        if (leftscore>= 10)
        {
            scoreText.text = "Left player has won!";
            xPosition = 0;
            yPosition = 0; 

        }
        else if (rightscore >= 10)
        {
            scoreText.text = "Right player has won!";
            xPosition = 0;
            yPosition = 0;

        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("auw!");
        if (collision.gameObject.name == ("topborder"))
        {
            Debug.Log("my head or my feed");
            randomSpeed = UnityEngine.Random.Range(5, 15);
            yspeed = yspeed * -1f;
        }
        if (collision.gameObject.name == ("bottombroder"))
        {
            Debug.Log("my but or crotch");
            randomSpeed = UnityEngine.Random.Range(5, 15);
            yspeed = yspeed * -1f;
        }
        if (collision.gameObject.name == "wall 1")
        {
            Debug.Log("uwu");
            randomSpeed = UnityEngine.Random.Range(5, 15);
            xspeed = xspeed * -1f;
        }
        if (collision.gameObject.name == "wall 2")
        {
            Debug.Log("owo");
            randomSpeed = UnityEngine.Random.Range(5, 15);
            xspeed = xspeed * -1f;
        }
        if (collision.gameObject.CompareTag("wallleft"))
        {
            scored = true;
            xPosition = 0f;
            yPosition = 0f;
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }
        if (collision.gameObject.CompareTag("rightwall"))
        {
            scored = true;
            xPosition = 0f;
            yPosition = 0f;
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }
        if (collision.gameObject.CompareTag("wallleft"))
        {
            xspeed = xspeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            rightscore++;
            scoreText.text = leftscore + " | " + rightscore;
        }
        if (collision.gameObject.CompareTag("rightwall"))
        {
            xspeed = xspeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            leftscore++;
            scoreText.text = leftscore + " | " + rightscore;
        }


    }

}
