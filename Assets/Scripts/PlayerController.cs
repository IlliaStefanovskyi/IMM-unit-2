using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float horizontalInput;
    public float playerSpeed = 10.0f;
    //xRange for changing the width of player travelling in x-axis if needed
    public float xRange = 10.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -1 * xRange)
        {
            transform.position = new Vector3(-1 * xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
    }
}
