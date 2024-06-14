using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erreignis_Karten : MonoBehaviour
{
    public void Erreignis_Karten_erreignise()
    {
        //Checkt watt is this for a Number and Execute the Column
        switch (GameManager.Erreignis_Kartenzahl)
        {
            case 0:
                // is the Colum Number 0 Check watt for a Position the Player have is this Correct Give Curren Player Money  Arround 200
                if (GameManager.Player_Positionen[GameManager.Next] == 17 || GameManager.Player_Positionen[GameManager.Next] == 33)
                {
                    GameManager.Player_Money[GameManager.Next] += 200;
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                }
                // Set the player to a new Position and Move it
                GameManager.Player_Positionen[GameManager.Next] = 11;
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();
                break;
            case 1:
                // is the Colum Number 1 Give the Curren Player Money Arround 100
                GameManager.Player_Money[GameManager.Next] += 100;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 2:
                // is the Colum Number 2 Give the Curren Player Money Arround 150
                GameManager.Player_Money[GameManager.Next] += 150;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 3:
                // is the Colum Number 3 Give The Player a Free Prision Card
                GameManager.Gefängnis_Freikarten[GameManager.Next] += 1;
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 4:
                // is the Colum Number 4 Set the Player to a New Position 0 and give the Player Money Arround 200
                GameManager.Player_Positionen[GameManager.Next] = 0;
                GameManager.Player_Money[GameManager.Next] += 200;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();
                break;
            case 5:
                // is the Colum Number 5 Give The Current Player Money Arround 150
                GameManager.Player_Money[GameManager.Next] += 150;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 6:
                // is the Colum Number 6 Move the Current Player to Position 39
                GameManager.Player_Positionen[GameManager.Next] = 39;
                break;
            case 7:
                // is the Colum Number 7 Check the Position wann this Correct Give the Current Player Money Arround 200
                if (GameManager.Player_Positionen[GameManager.Next] == 33)
                {
                    GameManager.Player_Money[GameManager.Next] += 200;
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                }
                // Set the Player Position to 24 
                GameManager.Player_Positionen[GameManager.Next] = 24;
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();
                break;
            case 8:
                // is the Colum Number 8 Set the Player Position 3 Fields back
                if (GameManager.Player_Positionen[GameManager.Next] == 2)
                {
                    GameManager.Player_Positionen[GameManager.Next] = 39;
                }
                else
                {
                    GameManager.Player_Positionen[GameManager.Next] -= 3;
                }
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();
                break;
            case 9:
                // is the Colum Number 9 Check All Streets if Possession the Current Player 
                Debug.Log("vor der Renuvierung " + GameManager.Player_Money[GameManager.Next] + " von Spieler " + GameManager.Next);
                for (int i = 0; i < 40; i++)
                {
                    if (GameManager.Freie_Straßen[i] == GameManager.Next)
                    {
                        // is it Correct Check what for a House step it is, depending on House Step Decrease Current Player Money
                        switch (GameManager.Haus_Stufe[i])
                        {
                            case 1:
                                GameManager.Player_Money[GameManager.Next] -= 50;
                                break;
                            case 2:
                                GameManager.Player_Money[GameManager.Next] -= 100;
                                break;
                            case 3:
                                GameManager.Player_Money[GameManager.Next] -= 150;
                                break;
                            case 4:
                                GameManager.Player_Money[GameManager.Next] -= 200;
                                break;
                            case 5:
                                GameManager.Player_Money[GameManager.Next] -= 100;
                                break;
                        }
                    }
                }
                Debug.Log("Nach der Renuvierung " + GameManager.Player_Money[GameManager.Next] + " von Spieler " + GameManager.Next);
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 10:
                // is the Colum Number 10, do the same what Colum NUmber 9 make
                Debug.Log("vor der Renuvierung " + GameManager.Player_Money[GameManager.Next] + " von Spieler " + GameManager.Next);
                for (int i = 0; i < 40; i++)
                {
                    if (GameManager.Freie_Straßen[i] == GameManager.Next)
                    {
                        switch (GameManager.Haus_Stufe[i])
                        {
                            case 1:
                                GameManager.Player_Money[GameManager.Next] -= 80;
                                break;
                            case 2:
                                GameManager.Player_Money[GameManager.Next] -= 160;
                                break;
                            case 3:
                                GameManager.Player_Money[GameManager.Next] -= 240;
                                break;
                            case 4:
                                GameManager.Player_Money[GameManager.Next] -= 320;
                                break;
                            case 5:
                                GameManager.Player_Money[GameManager.Next] -= 115;
                                break;
                        }
                    }
                }
                Debug.Log("nach der Renuvierung " + GameManager.Player_Money[GameManager.Next] + " von Spieler " + GameManager.Next);
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 11:
                // it the Colum Number 11 Decreas the Current Player Money Arround 20
                GameManager.Player_Money[GameManager.Next] -= 20;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 12:
                // it the Colum Number 12 Decreas the Current Player Money Arround 15
                GameManager.Player_Money[GameManager.Next] -= 15;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            case 13:
                // is the Colum Number 13 Move Current Player to a new Position and Set The Counter for Expose of 3
                GameManager.Player_Positionen[GameManager.Next] = 10;
                GameManager.Gefängnis[GameManager.Next] = 3;
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement>().Move_Players();
                break;
        }
    }
}
