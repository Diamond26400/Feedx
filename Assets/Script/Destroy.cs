using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float TopBond = 30.0f;
    private float lowBond = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBond)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBond) 
        {
            Destroy(gameObject);
        }
    } 
}
