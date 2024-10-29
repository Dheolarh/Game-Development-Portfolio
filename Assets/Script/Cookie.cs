using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    private float foodVelocity = 30.5f;
    private float dimensionBoundary = 18f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * foodVelocity);
        if (transform.position.z > dimensionBoundary)
        {
            Destroy(gameObject);
        }
    }
}
