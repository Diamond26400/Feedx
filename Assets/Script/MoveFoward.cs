using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
   private float destroyThreshold = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        move();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Check if the object's z-position is below the destroy threshold
        
    }
    private void move()
    {
        if (transform.position.z < destroyThreshold || transform.position.z > -destroyThreshold)
        {
            // Destroy the GameObject
            Destroy(gameObject);
        }
    }
}