
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movment : Behaviour
{
    /*[SyncVar(hook = nameof(HolaChanged))]
    public int holaCount = 0;


    void HandleMovment()
    {
        if (isLocalPlayer)
        {
            float moveHorizantal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizantal, moveVertical, 0);
            transform.position = transform.position + movement;
        }
    }

    void Update()
    {
        HandleMovment();

        if(isLocalPlayer && Input.GetKeyDown(KeyCode.X)) 
        {
            Debug.Log("Sending Hola to Server!");
            Hola();

            SceneManager.LoadScene(1);
            Debug.Log("Load New Scen");
        }
        else if (isLocalPlayer && Input.GetKeyDown(KeyCode.G))
        {
            test(holaCount);
        }

        if (isServer && transform.position.y > 50)
        {
            Toohigh();
        }



    }
    public void test(int holaCountt)
    {

        Debug.Log($"Die Aktuelle Zahl die Gespeicher ist {holaCountt}");

    }


    [Command]
    void Hola()
    {
        Debug.Log("Received Hola from client!");
        holaCount += 1;
        ReplyHola(holaCount);
    }

    [TargetRpc]
    void ReplyHola(int hholaCount)
    {
        holaCount = hholaCount;
        Debug.Log("Received Hola from Server!");
    }

    [ClientRpc]
    void Toohigh()
    {
        Debug.Log("Too high!");
    }

    void HolaChanged(int oldCount, int newCount)
    {
        SceneManager.LoadScene(1);
        Debug.Log("Load New Scen");
    }

    void test_2(int newCount)
    {

        holaCount = newCount;
        Debug.Log($"Set Hola Counter to {holaCount}");
    }*/
}
