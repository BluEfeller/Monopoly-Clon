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



    public void Oben_inv_Sceen()
    {
        for( int i = Zwischenberreich[0]; i <= Zwischenberreich[1]; i++)
        {
            switch (Viertel[i])
            {
                case 1:
                    Instantiate(Street_Cards[i], Fenster_Position[0].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 2:
                    Instantiate(Street_Cards[i], Fenster_Position[1].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 3:
                    Instantiate(Street_Cards[i], Fenster_Position[2].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 4:
                    Instantiate(Street_Cards[i], Fenster_Position[3].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 5:
                    Instantiate(Street_Cards[i], Fenster_Position[4].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 6:
                    Instantiate(Street_Cards[i], Fenster_Position[5].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 7:
                    Instantiate(Street_Cards[i], Fenster_Position[6].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 8:
                    Instantiate(Street_Cards[i], Fenster_Position[7].position, Quaternion.Euler(0, -180, 0));
                    break;
                case 9:
                    Instantiate(Street_Cards[i], Fenster_Position[8].position, Quaternion.Euler(0, -180, 0));
                    break;

            }
        }
    }

    public void Next_Site()
    {
        GameManager.Current_Sceen += 1;

        if (GameManager.Current_Sceen >= 5)
        {
            GameManager.Current_Sceen = 1;
        }
        Neuer_Berreich();
    }
    public void last_Site()
    {
        GameManager.Current_Sceen -= 1;

        if (GameManager.Current_Sceen <= 0)
        {
            GameManager.Current_Sceen = 4;
        }
        Neuer_Berreich();
    }

    public void Neuer_Berreich()
    {
        switch (GameManager.Current_Sceen) 
        {
            case 1:
                Zwischenberreich[0] = 0;
                Zwischenberreich[1] = 5;
                break;
            case 2:
                Zwischenberreich[0] = 6;
                Zwischenberreich[1] = 13;
                break;
            case 3:
                Zwischenberreich[0] = 14;
                Zwischenberreich[1] = 21;
                break;
            case 4:
                Zwischenberreich[0] = 22;
                Zwischenberreich[1] = 27;
                break;
        }
        Oben_inv_Sceen();
    } 
    
}
