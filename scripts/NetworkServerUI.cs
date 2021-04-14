using System;
using System.Collections;
using UnityEngine.Networking.NetworkSystem;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;



public class Network : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnGUI()
    {
        string ipaddress = Network.player.ipAddress;
        GUI.Box(new Rect(10, Screen.height - 50, 100, 50), ipaddress);
        GUI.Label(new Rect(20, Screen.height - 35, 100, 20), "ststus" + NetworkServer.active);
        GUI.Label(new Rect(20, Screen.height - 20, 100, 20), "connected" + NetworkServer.connections.Count);

    }
    void Start()
    {
        NetworkServer.Listen(25000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
