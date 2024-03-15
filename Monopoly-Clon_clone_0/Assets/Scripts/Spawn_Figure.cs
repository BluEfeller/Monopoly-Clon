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
    private int Figure_nummer = 0;




    public void Next_Spawn_Figur()
    {
        Figure_nummer++;
        Instantiate(Figur[Figure_nummer], new Vector3(-460, 324.059998f, -249.399994f), Quaternion.identity);
        if (Figure_nummer == 13)
        {
            Figure_nummer = -1;
        }
    }

    /*public void spawnen(int nummer)
    {
        GameObject aktuelanzeige;
        aktuelanzeige = Instantiate(Figur[nummer], Vector3.zero, Quaternion.identity);
    }
    */
}
