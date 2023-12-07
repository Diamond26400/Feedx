using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreferb;
    private float SpawnRangeX = 20.0f;
    private float SpawnProsZ = 20.0f;
    private float SpawnDelay = 2.0f;
    private float SpawnInterval = 1.5f;

   // Start is called before the first frame update

  public   void start ()
    {
        InvokeRepeating("SpawnRandomAnimal", SpawnDelay, SpawnInterval);
    }
    void Start()
    {
            
            SpawnRandomAnimal();
        
    }
    

    // Update is called once per frame
    void SpawnRandomAnimal()
    {
        // ramdomly generate animalIndex and spawm position

        int animalIndex = Random.Range(0, animalPreferb.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnProsZ);
        Instantiate(animalPreferb[animalIndex], spawnpos, animalPreferb[animalIndex].transform.rotation);

    }
}
 