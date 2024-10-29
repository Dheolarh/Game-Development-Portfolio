using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Variables")]
    [SerializeField] float horizontalInput;
    [SerializeField] float horizontalRange = 15f;
    [SerializeField] float speed = 15f;

    [Space,Header("Food Variables")]
    public GameObject food;
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        #region Player Movement

        if (transform.position.x < -horizontalRange)
        {
            transform.position = new Vector3(-horizontalRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > horizontalRange)
        {
            transform.position = new Vector3(horizontalRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        #endregion


        #region Food Movement

        bool throwFood = Input.GetKeyDown(KeyCode.Space);
        if (throwFood)
        {
            Instantiate(food, transform.position, food.transform.rotation);
        }

        #endregion

    }
}
