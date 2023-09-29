using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class playerControllerX : MonoBehaviour
{
    public float horizontalInput;
    public float xRange = 8.0f;
    public float Speed = 8.0f;
    public float move = 10.0f;
    PlayerInput PlayerInput;
    InputAction moveAction;
    // Start is called before the first frame update
    void Start()
    {
        PlayerInput = GetComponent<PlayerInput>();
        moveAction = PlayerInput.actions.FindAction("move");
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
     void update()
    {
        movePlayer();
    }
    void  movePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, direction.x) * Time.deltaTime;
    }

}
