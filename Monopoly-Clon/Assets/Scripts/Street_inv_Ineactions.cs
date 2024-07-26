using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street_inv_Ineactions : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Button;
    [SerializeField]
    private int Card_Number;
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Button[i].SetActive(false);
        }
        if (GameManager.Freie_Stra�en[Card_Number] == GameManager.Next)
        {
            if (GameManager.Offene_Hypoteken[Card_Number] == 0)
            {
                Button[2].SetActive(true);
            }
            else
            {
                Button[3].SetActive(true);
            }
            switch(Card_Number)
            {
                case 1: case 3:
                    if(GameManager.Freie_Stra�en[1] == GameManager.Next && GameManager.Freie_Stra�en[3] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 6: case 8: case 9:
                    if (GameManager.Freie_Stra�en[6] == GameManager.Next && GameManager.Freie_Stra�en[8] == GameManager.Next && GameManager.Freie_Stra�en[9] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 11: case 13: case 14:
                    if (GameManager.Freie_Stra�en[11] == GameManager.Next && GameManager.Freie_Stra�en[13] == GameManager.Next && GameManager.Freie_Stra�en[14] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 16: case 18: case 19:
                    if (GameManager.Freie_Stra�en[16] == GameManager.Next && GameManager.Freie_Stra�en[18] == GameManager.Next && GameManager.Freie_Stra�en[19] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 21: case 23: case 24:
                    if (GameManager.Freie_Stra�en[21] == GameManager.Next && GameManager.Freie_Stra�en[23] == GameManager.Next && GameManager.Freie_Stra�en[24] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 26: case 27: case 29:
                    if (GameManager.Freie_Stra�en[26] == GameManager.Next && GameManager.Freie_Stra�en[27] == GameManager.Next && GameManager.Freie_Stra�en[29] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 31: case 32: case 34:
                    if (GameManager.Freie_Stra�en[31] == GameManager.Next && GameManager.Freie_Stra�en[32] == GameManager.Next && GameManager.Freie_Stra�en[34] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 37: case 39:
                    if (GameManager.Freie_Stra�en[16] == GameManager.Next && GameManager.Freie_Stra�en[18] == GameManager.Next && GameManager.Freie_Stra�en[19] == GameManager.Next)
                    {
                        Button[0].SetActive(true);
                        Button[1].SetActive(true);
                    }
                    break;
                case 5: case 15: case 25: case 35: case 28: case 12:
                    Button[0].SetActive(false);
                    Button[1].SetActive(false);
                    break;
            }
        }
    }
    public void Hypoteken_Aufname_Human(int Wo)
    {
            //Hypoteken Aufnahme
            GameManager.Player_Money[GameManager.Next] += GameManager.Stra�en_Hypoteken[0, Wo];
            GameManager.Offene_Hypoteken[Wo] = 1;
            Button[2].SetActive(false);
            Button[3].SetActive(true);
  
        GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
    }
    public void Hypoteke_Abzahlung_Human(int Wo)
    {
        //Hypoteken Zur�ckzahlen
        GameManager.Player_Money[GameManager.Next] -= GameManager.Stra�en_Hypoteken[1, Wo];
        GameManager.Offene_Hypoteken[Wo] = 0;
        Button[3].SetActive(false);
        Button[2].SetActive(true);
        GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();

    }

    public void Call_Buy_Hause(int Wo) 
    {
        GameObject.Find("Hause_Manager").GetComponent<Heuser_Manager>().Haus_Zwischenbereich_Kauf(Wo);
    }
    public void Call_Sell_Hause(int Wo)
    {
        GameObject.Find("Hause_Manager").GetComponent<Heuser_Manager>().Haus_Zwischenbereich_Verkauf(Wo);
    }
}
