using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newSpawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject foodPrefab;
    // Start is called before the first frame update
    void instantiate(InputAction.PlayerInput input)
    {
        Debug.Log("Spawn");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Spawn"))
        {
            Instantiate(foodPrefab, Player.transform.position, Quaternion.identity);
        }
    }
}
