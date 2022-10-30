using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    // Start is called before the first frame update
    public float walkSpeed = 2.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IdentifyInput();
    }
    void IdentifyInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Movement (Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Movement(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Movement(Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Movement(Vector2.down);
        }
        


    }
    void Movement(Vector2 k) {
        transform.localPosition += (Vector3) (k * walkSpeed) * Time.deltaTime;

    }

}
