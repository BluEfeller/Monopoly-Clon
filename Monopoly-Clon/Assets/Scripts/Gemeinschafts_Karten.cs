using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gemeinschafts_Karten : MonoBehaviour
{
    public int Card_1 = 0;
    public void Gemeinschafts_Karte_Erreignise()
    {
        //Checkt watt is this for a Number and Execute the Column
        switch (GameManager.Gemeinschafts_Zahlen)
        {
            case 0:
                // is the Colum Number 0 Increas the Current Player Money Around 300 but all other Players money Decreas Around of 100
                Card_1 = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (GameManager.Player_Arten[i] == 1 || GameManager.Player_Arten[i] == 2)
                    {
                        GameManager.Player_Money[i] -= 100;
                        GameManager.Player_Money[GameManager.Next] += 100;
                    }
                }
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 1:
                // is the Colum Number 1 Increas the Current Player Money Around 5
                GameManager.Player_Money[GameManager.Next] += 5;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 2: case 7: case 8: case 13:
                // is the Colum Number 2/7/8/13 Increas the Curren Player Money Around 200
                GameManager.Player_Money[GameManager.Next] += 200;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 3:
                // is the Colum Number 3 Increas the Curren Player Money Around 10
                GameManager.Player_Money[GameManager.Next] += 10;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 4:
                // is the Colum Number 4 Increas the Curren Player Money Around 5
                GameManager.Player_Money[GameManager.Next] += 5;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 5:
                // is the Colum Number 5 Increas the Curren Player Money Around 200 and Set and Move The Player to Start Position
                GameManager.Player_Positionen[GameManager.Next] = 0;
                GameManager.Player_Money[GameManager.Next] += 200;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();
                break;
            case 6:
                // is the Colum Number 6 Give the Curren Player a Free Prison Card
                GameManager.Gefängnis_Freikarten[GameManager.Next] += 1;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 9:
                // is the Colum Number 9 Increas the Curren Player Money Around 25
                GameManager.Player_Money[GameManager.Next] += 25;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 10:
                // is the Colum Number 10 Inecreas the Curren Player Money Around 200 and Set and Move The Player to Position 1
                GameManager.Player_Positionen[GameManager.Next] = 1;
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();
                break;
            case 11:
                // is the Colum Number 11 Activate a Drop Down Menu for a Decision of Random or Draw a Erreignis Card or Pay 10
                //WHY.SetActive(true);
                if (GameManager.Player_Arten[GameManager.Next] == 1)
                {
                    Select_Gemeinschafts(0);
                }
                break;
            case 12:
                // is the Colum Number 12 set and move Current Player to Position 10 and Set The Counter for Expose of 3
                GameManager.Player_Positionen[GameManager.Next] = 10;
                GameManager.Gefängnis[GameManager.Next] = 3;
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();

                break;
            case 14:
                // is the Colum Number 14 Decrease the Current Player Money Around 50
                GameManager.Player_Money[GameManager.Next] -= 50;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 15:
                // is the Colum Number 15 Increase the Current Player Money Around 100
                GameManager.Player_Money[GameManager.Next] += 100;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
        }
    }

    //Function for the Colum Number 11
    public void Select_Gemeinschafts(int selecc)
    {
        // Activate The Drop Down Menu
        if (GameManager.Player_Arten[GameManager.Next] == 2)
        {
            GameObject.Find("Gemeinschafts_Auswahl_11").SetActive(true);
        }
        // Set a Random Numbe in Auswahl
        int Auswahl = Random.Range(0, 1);
        // Writing the Random number in the log
        Debug.Log(Auswahl);
        // Show it watt for Selection Used
        switch (selecc)
        {
            // is Colum Number 0 ( Random ) Selectet  Execoute this
            case 0:
                // is Show what for an Random Number it is
                switch (Auswahl)
                {
                    // is the Random Number 0 Decreas the Current Player Money Around 10
                    case 0:
                        GameManager.Player_Money[GameManager.Next] -= 10;
                        GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                        if (GameManager.Player_Arten[GameManager.Next] == 1)
                        {
                            GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                        }
                        break;
                    // is the Random Number 1 Deactivate the Gemeinschafts Card and Draw a Erreignis Card
                    case 1:
                        GameManager.Gemeinschafts_Karten[GameManager.Gemeinschafts_Zahlen].SetActive(false);
                        GameObject.Find("Erreignislogik").GetComponent<Erreignis_Karten>().Erreignis_Karten_erreignise();

                        break;
                }
                break;
            // is Colum Number 1 ( Strafe Zahlen ) Decreas the Current Player Money Around 10
            case 1:
                GameManager.Player_Money[GameManager.Next] -= 10;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            // is Colum Number 2 ( Erreignis Card ) Draw a Erreignis Card
            case 2:
                GameManager.Gemeinschafts_Karten[GameManager.Gemeinschafts_Zahlen].SetActive(false);
                GameObject.Find("Erreignislogik").GetComponent<Erreignis_Karten>().Erreignis_Karten_erreignise();
                break;
        }

    }
}
