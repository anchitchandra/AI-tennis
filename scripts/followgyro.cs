using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followgyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        gyromanager.Instance.EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = gyromanager.Instance.GetGyroRotation() * baseRotation;
    }
}
