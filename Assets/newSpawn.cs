using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newSpawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject foodPrefab;

    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, Player.transform.position, Quaternion.identity);
        }
        Debug.Log("Spawn");
    }
}
