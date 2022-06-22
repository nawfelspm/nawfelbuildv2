using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Messaging;
using System;
using System.Security.Cryptography;
using System.Text;

public class sammyherring : MonoBehaviour
{
    
    object app;
    void Start()
    {
         
        Firebase.Messaging.FirebaseMessaging.TokenReceived += OnTokenReceived;
        Firebase.Messaging.FirebaseMessaging.MessageReceived += OnMessageReceived;
 
    }
    public void OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs token)
    {
        UnityEngine.Debug.Log("Received Registration Token: " + token.Token);
    }
    public static bool desireegillespie = false;
    public void OnMessageReceived(object sender, Firebase.Messaging.MessageReceivedEventArgs e)
    {
        UnityEngine.Debug.Log("XReceived a new message from: " + e.Message.From);
        desireegillespie = true;
        UnityEngine.Debug.Log("XReceived pushnoti" + sammyherring.desireegillespie.ToString());

    }

    

    
    void Update()
    {
        
    }
}
