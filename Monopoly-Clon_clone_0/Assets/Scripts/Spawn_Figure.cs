using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Mirror;
using System.Security.Principal;

public class Spawn_Figure : NetworkBehaviour
{
    [SerializeField] private Vector3 _rotation;

    [SerializeField]
    private GameObject[] Figur;

    [SerializeField]
    private string[] Figur_Namen;
    [SyncVar] int[] Figure_nummer = { 1, 1, 1, 1 };
    private GameObject Player_1;
    private GameObject Player_2;
    private GameObject Player_3;
    private GameObject Player_4;

    void Start()
    {
        Instantiate(Figur[Figure_nummer[0]], new Vector3(-609, 675, -151), Quaternion.identity);
        GameObject.Find("Big Rig Variant(Clone)").name = "Player_1";

        Instantiate(Figur[Figure_nummer[1]], new Vector3(-201.300003f, 675, -151), Quaternion.identity);
        GameObject.Find("Big Rig Variant(Clone)").name = "Player_2";

        Instantiate(Figur[Figure_nummer[2]], new Vector3(208, 675, -151), Quaternion.identity);
        GameObject.Find("Big Rig Variant(Clone)").name = "Player_3";

        Instantiate(Figur[Figure_nummer[3]], new Vector3(613, 675, -151), Quaternion.identity);
        GameObject.Find("Big Rig Variant(Clone)").name = "Player_4";
    }
    void Update()
    {

    }


    [Command]
    public void CmdNext_Spawn_Figur_1()
    {
        
            if (GameObject.Find("Player_1") == true)
            {
                Player_1 = GameObject.Find("Player_1");
                Destroy(Player_1);
            }
            Figure_nummer[0]++;
            if (Figure_nummer[0] > 12)
            {
                Figure_nummer[0] = 0;
            }
            /*var test1 = */Instantiate(Figur[Figure_nummer[0]], new Vector3(-609, 675, -151f), Quaternion.identity);
            //NetworkServer.Spawn(test1, connectionToClient);
            if (GameObject.Find(Figur_Namen[Figure_nummer[0]]) == true)
            {
                GameObject.Find(Figur_Namen[Figure_nummer[0]]).name = "Player_1";
            }
        test4(Figure_nummer[0]);
        
    }

    [ClientRpc]
    void test4(int Nummer)
    {
        Spawn_Figur_1_Client(Nummer);
        Debug.Log("geht zur erweiterten Funktion");
    }



    void Spawn_Figur_1_Client(int Nummer)
    {
            if (GameObject.Find("Player_1") == true)
            {
                Player_1 = GameObject.Find("Player_1");
                Destroy(Player_1);
            }
            Instantiate(Figur[Nummer], new Vector3(-609, 675, -151f), Quaternion.identity);
            //NetworkServer.Spawn(test1, connectionToClient);
            if (GameObject.Find(Figur_Namen[Nummer]) == true)
            {
                GameObject.Find(Figur_Namen[Nummer]).name = "Player_1";
            }
    }


    public void Next_Spawn_Figur_2()
    {
        if (GameObject.Find("Player_2") == true)
        {

            Player_2 = GameObject.Find("Player_2");
            Destroy(Player_2);
        }
        Figure_nummer[1]++;
        if (Figure_nummer[1] > 12)
        {
            Figure_nummer[1] = 0;
        }
        Instantiate(Figur[Figure_nummer[1]], new Vector3(-191.300003f, 675, -151), Quaternion.identity);

        if (GameObject.Find(Figur_Namen[Figure_nummer[1]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[1]]).name = "Player_2";
        }
    }


    public void Next_Spawn_Figur_3()
    {
        if (GameObject.Find("Player_3") == true)
        {

            Player_3 = GameObject.Find("Player_3");
            Destroy(Player_3);
        }
        Figure_nummer[2]++;
        if (Figure_nummer[2] > 12)
        {
            Figure_nummer[2] = 0;
        }
        Instantiate(Figur[Figure_nummer[2]], new Vector3(189, 675, -151f), Quaternion.identity);

        if (GameObject.Find(Figur_Namen[Figure_nummer[2]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[2]]).name = "Player_3";
        }
    }


    public void Next_Spawn_Figur_4()
    {
        if (GameObject.Find("Player_4") == true)
        {

            Player_4 = GameObject.Find("Player_4");
            Destroy(Player_4);
        }
        Figure_nummer[3]++;
        if (Figure_nummer[3] > 12)
        {
            Figure_nummer[3] = 0;
        }
        Instantiate(Figur[Figure_nummer[3]], new Vector3(512, 675, -151), Quaternion.identity);

        if (GameObject.Find(Figur_Namen[Figure_nummer[3]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[3]]).name = "Player_4";
        }

    }
    /*public void spawnen(int nummer)
    {Car2 Variant(Clone)
        GameObject aktuelanzeige;
        aktuelanzeige = Instantiate(Figur[nummer], Vector3.zero, Quaternion.identity);
    }
    */
}
