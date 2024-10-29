using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float ballSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * ballSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dog"))
        {
            Debug.Log("Scored");
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
