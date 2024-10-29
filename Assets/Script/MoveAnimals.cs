using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimals : MonoBehaviour
{
    private Transform spawnPoint;
    private float speed = 3f;
    private float dimensionBoundaryPositive = 18f;
    private float dimensionBoundaryNegative = 7f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z > dimensionBoundaryPositive)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -dimensionBoundaryNegative)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
