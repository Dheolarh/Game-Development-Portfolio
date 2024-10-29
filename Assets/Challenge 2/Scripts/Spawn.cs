using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Dog;
    public GameObject[] Balls;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BallsSpawning", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        DogSpawning();
    }

    void DogSpawning()
    {
        bool spawnDog = Input.GetKeyDown(KeyCode.Space);
        Vector3 spawnPosition = new Vector3(33f, 0, 0);
        if (spawnDog)
        {
            Instantiate(Dog, spawnPosition, Dog.transform.rotation);
        }
    }

    void BallsSpawning()
    {
        int ballLength = Balls.Length;
        int spawnRange = Random.Range(0, ballLength);
        Vector3 spawnDimension = new Vector3(Random.Range(-22, 8), 23, 0);
        Instantiate(Balls[spawnRange], spawnDimension, Balls[spawnRange].transform.rotation);
    }
}
