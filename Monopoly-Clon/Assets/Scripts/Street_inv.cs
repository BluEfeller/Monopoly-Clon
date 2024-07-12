using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street_inv : MonoBehaviour
{

    public Transform[] Fenster_Position;
    public GameObject[] Street_Cards;
    public int[] Viertel;
    public GameObject[] Spawned_Card;
    public int[] Zwischenberreich = new int[2];
    private int Site = 0;



    public void Oben_inv_Sceen()
    {
        for( int i = Zwischenberreich[0]; i <= Zwischenberreich[1]; i++)
        {
            switch(Viertel[i])
            {
                case 1:
                    Instantiate(Street_Cards[i], Fenster_Position[0].position, Quaternion.identity);
                    break;

            }
        }
    }

    public void Next_Site()
    {
        Site += 1;
        
    }

    public void Neuer_Berreich()
    {
        switch (Site) 
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4: 

                break;
        }

    }                       
}
