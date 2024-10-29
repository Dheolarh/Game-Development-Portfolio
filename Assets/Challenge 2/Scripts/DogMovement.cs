using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    private float speed = 20f;
    private float xRange = 31f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
    }
}
