using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerX : MonoBehaviour
{
    public float xRange = 8.0f;
    public float Speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * Time.deltaTime * Speed, 0, 0);

        // Limit the player's position within the specified xRange
        newPosition.x = Mathf.Clamp(newPosition.x, -xRange, xRange);

        // Apply the new position to the player
        transform.position = newPosition;
    }
}

