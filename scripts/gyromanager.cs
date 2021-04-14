using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyromanager : MonoBehaviour
{
    #region Instance
    private static gyromanager instance;
    public static gyromanager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<gyromanager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned gyromanager", typeof(gyromanager)).GetComponent<gyromanager>();
                }
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }
    #endregion

    [Header("Logic")]
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;
    
    public void EnableGyro()
    {
        //to check if it is active or not bruh
        if (gyroActive)
        {
            return;
        }
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
        }
        else
        {
            Debug.Log("gyro not present on the connected device");
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    private void Update()
    {
        if (gyroActive)
        {
            rotation = gyro.attitude;
        }
    }
    public Quaternion GetGyroRotation()
    {
        return rotation;
    }
}
