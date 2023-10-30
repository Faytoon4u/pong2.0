using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;


public class goal1 : MonoBehaviour
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

    }

    // Update is called once per frame
    void Update()
    {
        if (leftscore>= 7)
        {
            scoreText.text = "lost...";
            xPosition = 0;
            yPosition = 0; 

        }
        else if (rightscore >= 7)
        {
            scoreText.text = "WON!!";
            xPosition = 0;
            yPosition = 0;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wallleft"))
        {
            xspeed = xspeed * 1f;
            xPosition = 0;
            yPosition = 0;
            leftscore++;
            scoreText.text = leftscore + " - " + rightscore;
        }
        if (collision.gameObject.CompareTag("rightwall"))
        {
            xspeed = xspeed * 1f;
            xPosition = 0;
            yPosition = 0;
            rightscore++;
            scoreText.text = leftscore + " - " + rightscore;
        }
    }

}

