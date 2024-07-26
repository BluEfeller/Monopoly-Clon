using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straßen_Interraktion : MonoBehaviour
{
    [SerializeField]
    private GameObject Kauf_Button;

    void Start()
    {
        Kauf_Button.SetActive(false);
    }

    public void Buy_Human()
    {
        GameManager.Freie_Straßen[GameManager.Player_Positionen[GameManager.Next]] = GameManager.Next;
        GameManager.Player_Money[GameManager.Next] -= GameManager.Straßen_Kaufpreise[GameManager.Player_Positionen[GameManager.Next]];
        GameManager.Player_Straßen_Besitz_Anzeige[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].SetActive(true);
        GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
        if (GameManager.Player_Positionen[GameManager.Next] == 5 || GameManager.Player_Positionen[GameManager.Next] == 15 || GameManager.Player_Positionen[GameManager.Next] == 25 || GameManager.Player_Positionen[GameManager.Next] == 35)
        {
            I_like_trains();
        }
        Hide_Kaufbutton();
    }
    public void Hide_Kaufbutton()
    {
        Kauf_Button.SetActive(false);
    }

    public void I_like_trains()
    {
        // is this Correct set in the Variable Bahnfos_Besitzs Series of this bot and increse it
        GameManager.Bahnhofs_Besitz[GameManager.Next] += 1;
        // is it more als 2 use this Switch and Changed the Haus_Stufe up
        switch (GameManager.Bahnhofs_Besitz[GameManager.Next])
        {
            case 2:
                // if it the Same Nummer Use it and increase Haus_Stufe of the Bahnhof 
                if (GameManager.Freie_Straßen[5] == GameManager.Next) { GameManager.Haus_Stufe[5] = 1; }
                if (GameManager.Freie_Straßen[15] == GameManager.Next) { GameManager.Haus_Stufe[15] = 1; }
                if (GameManager.Freie_Straßen[25] == GameManager.Next) { GameManager.Haus_Stufe[25] = 1; }
                if (GameManager.Freie_Straßen[35] == GameManager.Next) { GameManager.Haus_Stufe[35] = 1; }
                break;
            case 3:
                if (GameManager.Freie_Straßen[5] == GameManager.Next) { GameManager.Haus_Stufe[5] = 2; }
                if (GameManager.Freie_Straßen[15] == GameManager.Next) { GameManager.Haus_Stufe[15] = 2; }
                if (GameManager.Freie_Straßen[25] == GameManager.Next) { GameManager.Haus_Stufe[25] = 2; }
                if (GameManager.Freie_Straßen[35] == GameManager.Next) { GameManager.Haus_Stufe[35] = 2; }
                break;
            case 4:
                if (GameManager.Freie_Straßen[5] == GameManager.Next) { GameManager.Haus_Stufe[5] = 3; }
                if (GameManager.Freie_Straßen[15] == GameManager.Next) { GameManager.Haus_Stufe[15] = 3; }
                if (GameManager.Freie_Straßen[25] == GameManager.Next) { GameManager.Haus_Stufe[25] = 3; }
                if (GameManager.Freie_Straßen[35] == GameManager.Next) { GameManager.Haus_Stufe[35] = 3; }
                break;
        }
    }

    public void Kaufpaar()
    {
        // Check of the Player a Human or a Bot
        // if Human use this Code
        if (GameManager.Player_Arten[GameManager.Next] == 2)
        {
            // Human Part
            if (GameManager.Freie_Straßen[GameManager.Player_Positionen[GameManager.Next]] == -1)
            {
                Kauf_Button.SetActive(true);
            }
            else
            {
                // Decrease the Player Money with the Rent of the Street House level
                GameManager.Player_Money[GameManager.Next] -= GameManager.Haus_Stufen_Mietpreise[GameManager.Haus_Stufe[GameManager.Player_Positionen[GameManager.Next]], GameManager.Player_Positionen[GameManager.Next]];
                // Increase the Player Money of the Owner this street
                GameManager.Player_Money[GameManager.Freie_Straßen[GameManager.Player_Positionen[GameManager.Next]]] += GameManager.Haus_Stufen_Mietpreise[GameManager.Haus_Stufe[GameManager.Player_Positionen[GameManager.Next]], GameManager.Player_Positionen[GameManager.Next]];
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
            }
        }
        // if Bot use this Code
        else if (GameManager.Player_Arten[GameManager.Next] == 1)
        {
            // Bot Part
            // if the street the Player Position is -1 use this
            if (GameManager.Freie_Straßen[GameManager.Player_Positionen[GameManager.Next]] == -1)
            {
                int AutoKauf = Random.Range(0, 100); // Set Random Nummer für Buy a Street or not
                // if Random Nummer (AutoKauf) under 50 is buy The Street not
                if (AutoKauf < 50)
                {

                }
                // if Random Nummer (AutoKauf) upper 50 is Check if the bot Enough Money have
                else if (GameManager.Player_Money[GameManager.Next] >= GameManager.Straßen_Kaufpreise[GameManager.Player_Positionen[GameManager.Next]])
                {
                    // Set the Street Number to bot Nummber
                    GameManager.Freie_Straßen[GameManager.Player_Positionen[GameManager.Next]] = GameManager.Next;
                    // Set the bot Money and Remove Street Buy Summe
                    GameManager.Player_Money[GameManager.Next] -= GameManager.Straßen_Kaufpreise[GameManager.Player_Positionen[GameManager.Next]];
                    // Set in the bot Interface a not active Cube for the Buyed Street active
                    GameManager.Player_Straßen_Besitz_Anzeige[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].SetActive(true);
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                    // write in the log watt the bot a buyed Street have
                    // if bot of this Position use this is it not use this not
                    if (GameManager.Player_Positionen[GameManager.Next] == 5 || GameManager.Player_Positionen[GameManager.Next] == 15 || GameManager.Player_Positionen[GameManager.Next] == 25 || GameManager.Player_Positionen[GameManager.Next] == 35)
                    {
                        I_like_trains();
                    }
                }
            }
            // if up not Correct use this
            else
            {
                    // Decrease the Player Money with the Rent of the Street House level
                    GameManager.Player_Money[GameManager.Next] -= GameManager.Haus_Stufen_Mietpreise[GameManager.Haus_Stufe[GameManager.Player_Positionen[GameManager.Next]],GameManager.Player_Positionen[GameManager.Next]];
                    // Increase the Player Money of the Owner this street
                    GameManager.Player_Money[GameManager.Freie_Straßen[GameManager.Player_Positionen[GameManager.Next]]] += GameManager.Haus_Stufen_Mietpreise[GameManager.Haus_Stufe[GameManager.Player_Positionen[GameManager.Next]], GameManager.Player_Positionen[GameManager.Next]];
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
            }
            if (GameManager.Player_Arten[GameManager.Next] == 1)
            {
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
            }
        }
    }
}
