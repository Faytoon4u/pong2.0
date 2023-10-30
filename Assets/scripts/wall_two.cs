using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_two : MonoBehaviour
{
    public string LeftOrRight;
    public float speed = 10f;
    public bool hitTop = false;
    public bool hitBottom = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        paddelContorol(KeyCode.UpArrow, KeyCode.DownArrow);
    }
   
    void paddelContorol(KeyCode up, KeyCode down)

    {
        if (Input.GetKey(up))
        {
            if (!hitTop)
            {
                Debug.Log("yo up");
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(down))
        {
            if (!hitBottom)
            {
                Debug.Log("yo down");
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }

        }


    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("topborder"))
        {
            hitTop = true;
        }
        if (collision.gameObject.name == ("bottombroder"))
        {
            hitBottom = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        hitBottom = false;
        hitTop = false;
    }
}
