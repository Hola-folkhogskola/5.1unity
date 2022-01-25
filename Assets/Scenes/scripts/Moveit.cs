using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveit : MonoBehaviour
{
    public float movementSpeed_f = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    // Character movement
    void Move()
    {
        // 1. Get key presses A & D
        if (Input.GetKey(KeyCode.A))
        {
            print("Player pressed A button, character should move left");

            // character should move left
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed_f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Player pressed D button, character should move right");

            // character should move right
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed_f);
        }

        // 2. On press A character should move left, On press D character should move right
        // 3. If player releases key, character stops movings

    }
}
