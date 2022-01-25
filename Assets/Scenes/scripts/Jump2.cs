using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour
{
    /*
     * go up when pressing a button
     * 1. get player input when player presses spacebar
     * 2. character goes upwards
     */

    public float jumpForce_f = 1.0f;

    Rigidbody2D characterRB;
    bool touchingPlatform = false;

    // Start is called before the first frame update
    void Start()
    {
        //find the character's rigidbody
        characterRB = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Jumpy();


    }

    void Jumpy()
    {
        //1. get player input when player presses spacebar
        if (Input.GetKeyDown(KeyCode.Space) && touchingPlatform == true)
        {
            print("test");
            //2. character goes upwards
            //transform.Translate(Vector3.up * Time.deltaTime * jumpForce_f);

            characterRB.AddForce(Vector2.up, ForceMode2D.Impulse);
        }

    }

    // check if character is touching the platform
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "platform")
        {
            touchingPlatform = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "platform")
        {
            touchingPlatform = false;
        }
    }
}

