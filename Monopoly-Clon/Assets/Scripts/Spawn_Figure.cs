using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn_Figure : MonoBehaviour
{
    [Header("Figuren von 1 - 13")]
    [SerializeField]
    private GameObject[] Figur;

 

    /*public void spawnen(int nummer)
    {
        GameObject aktuelanzeige;
        aktuelanzeige = Instantiate(Figur[nummer], Vector3.zero, Quaternion.identity);
    }
    */
}
