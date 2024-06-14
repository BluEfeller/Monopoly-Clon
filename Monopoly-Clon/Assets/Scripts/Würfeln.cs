using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Würfeln : MonoBehaviour
{
    public void Roll_the_Dice()
    {
        // Checks whether the player rolled the dice
        if (GameManager.Würfel_Versuch == 0)
        {
            // Check is Player in Prison or is Player don't in the Prison
            if (GameManager.Gefängnis[GameManager.Next] == 0)
            {
                GameManager.Würfel_Versuch = 1; // set the Dice Try of 1 
                GameManager.Würfel[0] = Random.Range(1, 7);//Random Number From 1 to 6 for the Dice
                GameManager.Würfel[1] = Random.Range(1, 7);//Random Number From 1 to 6 for the Dice
                GameManager.Gemeinschafts_Zahlen = Random.Range(0, 15);//Random Number From 1 to 14 for the Community cards
                GameManager.Erreignis_Kartenzahl = Random.Range(0, 13);//Random Number From 1 to 12 for the Event Cards
                GameManager.Player_Positionen[GameManager.Next] += GameManager.Würfel[0] + GameManager.Würfel[1]; // add Total Dice 1  Dice 2 Nummber and Counts to Player_Posision 
                //This if Checks The Player_Position up over 39 is and is it true Give the Player 200€ and
                //Changes the Player Position with a Modulo under 39 ( 55 - 39 is the new position 15 )
                if (GameManager.Player_Positionen[GameManager.Next] > 39)
                {
                    GameManager.Player_Money[GameManager.Next] += 200;
                    GameManager.Player_Positionen[GameManager.Next] = GameManager.Player_Positionen[GameManager.Next] % 40;
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen(); // Calld the Funktion Change_Money_Screen
                }
                GameObject.Find("Player_Move").GetComponent<PLayer_Movement> ().Move_Players(); // Calld the Funktion Move_Players
            }
            else // is the uper if not True Remove the Prision Stay around 1
            {
                GameManager.Gefängnis[GameManager.Next] -= 1;
                // Checkt op you a Human or Bot
                if (GameManager.Player_Arten[GameManager.Next] == 1)
                {
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next(); // Calld the Funktion Move_Players but Delayed
                }
            }
        }
    }
}
