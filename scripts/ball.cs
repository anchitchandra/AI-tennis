using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Vector3 initialPos;

    // Start is called before the first frame update
    private void Start()
    {
        initialPos = transform.position; 
    }

     private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("wall"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = initialPos;
        }
    }
}
