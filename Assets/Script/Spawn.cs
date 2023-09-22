using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Projectpreferb;
    public float SpawnInterval = 1.0f;
    private float timer = 0;
    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R) && timer > SpawnInterval)
        {
            SpawnFood();
            timer = 0;
        }

    }

    // Update is called once per frame
    void SpawnFood()
    {

        GameObject Food = Instantiate(Projectpreferb, spawnPosition, Quaternion.identity);
        Projectpreferb.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 1);
    }
}