using System;
using System.Collections;
using System.Collections.Generic;
using MetaMask.Models;
using MetaMask.Transports.Unity;
using UnityEngine;

public class LoginMnager : MonoBehaviour, IMetaMaskUnityTransportListener

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMetaMaskConnectRequest(string url)
    {
    }

    public void OnMetaMaskRequest(string id, MetaMaskEthereumRequest request)
    {
    }

    public void OnMetaMaskFailure(Exception error)
    {
    }

    public void OnMetaMaskSuccess()
    {
    }
}
