using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watt_for_Field : MonoBehaviour
{
    public void Check_Player_Field()
    {
        // Check the player Position and this Field of Player Position
        switch (GameManager.Player_Positionen[GameManager.Next])
        {
            case 2: case 17: case 33:
                GameManager.Erreignis_Karten[GameManager.Erreignis_Kartenzahl].SetActive(true);
                GameObject.Find("Erreignislogik").GetComponent<Erreignis_Karten>().Erreignis_Karten_erreignise();
                if (GameManager.Player_Arten[GameManager.Next] == 1)
                {
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                }
                break;
            case 7: case 22: case 36:
                GameManager.Gemeinschafts_Karten[GameManager.Gemeinschafts_Zahlen].SetActive(true);
                GameObject.Find("Gemeinschaftlogik").GetComponent<Gemeinschafts_Karten>().Gemeinschafts_Karte_Erreignise();
                break;
            case 4:
                GameManager.Player_Money[GameManager.Next] -= 200;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                if (GameManager.Player_Arten[GameManager.Next] == 1)
                {
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                }
                break;
            case 38:
                GameManager.Player_Money[GameManager.Next] -= 100;
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
                if (GameManager.Player_Arten[GameManager.Next] == 1)
                {
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                }
                break;
            case 12: case 28:
                if (GameManager.Freie_Straßen[12] == GameManager.Freie_Straßen[28])
                {
                    GameManager.Haus_Stufen_Mietpreise[0, 12] = GameManager.Würfel[0] + GameManager.Würfel[1] * 10;
                    GameManager.Haus_Stufen_Mietpreise[0, 28] = GameManager.Würfel[0] + GameManager.Würfel[1] * 10;
                }
                else
                {
                    GameManager.Haus_Stufen_Mietpreise[0, 12] = GameManager.Würfel[0] + GameManager.Würfel[1] * 4;
                    GameManager.Haus_Stufen_Mietpreise[0, 28] = GameManager.Würfel[0] + GameManager.Würfel[1] * 4;
                }
                GameObject.Find("Straßen_In").GetComponent<Straßen_Interraktion>().Kaufpaar();
                break;
            case 10:
                {
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                }
                break;
            case 20:
                    GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Wait_Next();
                break;
            default:
                GameManager.Straßen_Karten[GameManager.Player_Positionen[GameManager.Next]].SetActive(true);
                GameObject.Find("Straßen_In").GetComponent<Straßen_Interraktion>().Kaufpaar();
                break;
        }
        GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
    }
}
