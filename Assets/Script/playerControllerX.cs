using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerX : MonoBehaviour
{
    public float horizontalInput;
    public float xRange = 8.0f;
    public float Speed = 8.0f;
    public float move = 10.0f;
    // Start is called before the first frame update
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Speed);

   
        }

    }
