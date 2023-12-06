using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float TopBond = 30.0f;
    private float lowBond = -30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Remove that object when the player goes pass the scene
        if (transform.position.z < lowBond || transform.position.z > TopBond)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific tag
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the collided object
            Destroy(collision.gameObject);

            // Optionally, destroy the object with this script as well
            Destroy(gameObject);

            // Log a message
            Debug.Log("Collided with and destroyed an enemy!");
        }
    }
}