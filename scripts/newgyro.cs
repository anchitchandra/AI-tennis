using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newgyro : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }
    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
