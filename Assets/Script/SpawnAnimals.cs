using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] Animals;
    private float dimensionBoundaryPositive = 18f;
    private float spawnX = 15f;
    private float spawnZ = 18f;



    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating takes in "Function name as a string", start Time for invocation, and time interval between each invokes.
        InvokeRepeating("RandomSpawning", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RandomSpawning()
    {
        int totalAnimals = Animals.Length;
        int spawnRandom = Random.Range(0, totalAnimals);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        
        if (transform.position.z < dimensionBoundaryPositive)
        {
            Instantiate(Animals[spawnRandom], spawnPosition, Animals[spawnRandom].transform.rotation);
        } 
    }
}
