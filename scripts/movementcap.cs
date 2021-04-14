using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementcap : MonoBehaviour
{
    public Transform aimTarget;
    float force = 20;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Vector3 dir = aimTarget.position - transform.position;
            other.GetComponent<Rigidbody>().velocity = dir.normalized*force + new Vector3(0,15,0);
        }
    }
}
