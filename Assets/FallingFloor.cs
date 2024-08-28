using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour
{
    private Vector3 initialPosition;
    private bool falling;
    private int fallingSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(falling == true)
        {
            transform.position -= new Vector3(0,fallingSpeed * Time.deltaTime,0);
        }

        if(transform.position.y <= -10)
        {
            transform.position = initialPosition;
            falling = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            falling = true;
        }
    }
}
