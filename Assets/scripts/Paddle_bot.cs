using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_bot : MonoBehaviour
{
    public float speed = 5.0f;  // Adjust the speed as needed
    public float minY = (float)-3.13;  // The lowest position
    public float maxY = 3.13f;  // The highest position
    private bool movingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y >= maxY)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y <= minY)
            {
                movingUp = true;
            }
        }
    }
}
