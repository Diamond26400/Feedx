using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movefwd : MonoBehaviour
{
    public float speed = 40.0f;
    public float destroyThreshold = -10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Check if the object's z-position is below the destroy threshold
        if (transform.position.z < destroyThreshold || transform.position.z > -destroyThreshold)
        {
            // Destroy the GameObject
            Destroy(gameObject);
        }
    }
}
