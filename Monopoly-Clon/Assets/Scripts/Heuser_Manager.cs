using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heuser_Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Heuser;

    private int[] Heuser_Bereich;
    private int O = 0;

    void Start()
    {
        for (int i = 0; i < 110; i++)
        {
            Heuser[i].SetActive(false);
        }
    }

    public void Haus_Zwischenbereich_Verkauf(int Platz)
    {
        switch(Platz) 
        {
            case 0:
                Heuser_Bereich[0] = 0;
                Heuser_Bereich[1] = 4;
                Heuser_Bereich[2] = 1;
                break;
            case 1:
                Heuser_Bereich[0] = 5;
                Heuser_Bereich[1] = 9;
                Heuser_Bereich[2] = 3;
                break;
            case 2:
                Heuser_Bereich[0] = 10;
                Heuser_Bereich[1] = 14;
                Heuser_Bereich[2] = 6;
                break;
            case 3:
                Heuser_Bereich[0] = 15;
                Heuser_Bereich[1] = 19;
                Heuser_Bereich[2] = 8;
                break;
            case 4:
                Heuser_Bereich[0] = 20;
                Heuser_Bereich[1] = 24;
                Heuser_Bereich[2] = 9;
                break;
            case 5:
                Heuser_Bereich[0] = 25;
                Heuser_Bereich[1] = 29;
                Heuser_Bereich[2] = 11;
                break;
            case 6:
                Heuser_Bereich[0] = 30;
                Heuser_Bereich[1] = 34;
                Heuser_Bereich[2] = 13;
                break;
            case 7:
                Heuser_Bereich[0] = 35;
                Heuser_Bereich[1] = 39;
                Heuser_Bereich[2] = 14;
                break;
            case 8:
                Heuser_Bereich[0] = 40;
                Heuser_Bereich[1] = 44;
                Heuser_Bereich[2] = 16;
                break;
            case 9:
                Heuser_Bereich[0] = 45;
                Heuser_Bereich[1] = 49;
                Heuser_Bereich[2] = 18;
                break;
            case 10:
                Heuser_Bereich[0] = 50;
                Heuser_Bereich[1] = 54;
                Heuser_Bereich[2] = 19;
                break;
            case 11:
                Heuser_Bereich[0] = 55;
                Heuser_Bereich[1] = 59;
                Heuser_Bereich[2] = 21;
                break;
            case 12:
                Heuser_Bereich[0] = 60;
                Heuser_Bereich[1] = 64;
                Heuser_Bereich[2] = 23;
                break;
            case 13:
                Heuser_Bereich[0] = 65;
                Heuser_Bereich[1] = 69;
                Heuser_Bereich[2] = 24;
                break;
            case 15:
                Heuser_Bereich[0] = 70;
                Heuser_Bereich[1] = 74;
                Heuser_Bereich[2] = 26;
                break;
            case 16:
                Heuser_Bereich[0] = 75;
                Heuser_Bereich[1] = 79;
                Heuser_Bereich[2] = 27;
                break;
            case 17:
                Heuser_Bereich[0] = 80;
                Heuser_Bereich[1] = 84;
                Heuser_Bereich[2] = 29;
                break;
            case 18:
                Heuser_Bereich[0] = 85;
                Heuser_Bereich[1] = 89;
                Heuser_Bereich[2] = 31;
                break;
            case 19:
                Heuser_Bereich[0] = 90;
                Heuser_Bereich[1] = 94;
                Heuser_Bereich[2] = 32;
                break;
            case 20:
                Heuser_Bereich[0] = 95;
                Heuser_Bereich[1] = 99;
                Heuser_Bereich[2] = 34;
                break;
            case 21:
                Heuser_Bereich[0] = 100;
                Heuser_Bereich[1] = 104;
                Heuser_Bereich[2] = 37;
                break;
            case 22:
                Heuser_Bereich[0] = 105;
                Heuser_Bereich[1] = 109;
                Heuser_Bereich[2] = 39;
                break;
        }

            Sell_Haus();
    }
    public void Haus_Zwischenbereich_Kauf(int Platz)
    {
        switch (Platz)
        {
            case 0:
                Heuser_Bereich[0] = 0;
                Heuser_Bereich[1] = 4;
                Heuser_Bereich[2] = 1;
                break;
            case 1:
                Heuser_Bereich[0] = 5;
                Heuser_Bereich[1] = 9;
                Heuser_Bereich[2] = 3;
                break;
            case 2:
                Heuser_Bereich[0] = 10;
                Heuser_Bereich[1] = 14;
                Heuser_Bereich[2] = 6;
                break;
            case 3:
                Heuser_Bereich[0] = 15;
                Heuser_Bereich[1] = 19;
                Heuser_Bereich[2] = 8;
                break;
            case 4:
                Heuser_Bereich[0] = 20;
                Heuser_Bereich[1] = 24;
                Heuser_Bereich[2] = 9;
                break;
            case 5:
                Heuser_Bereich[0] = 25;
                Heuser_Bereich[1] = 29;
                Heuser_Bereich[2] = 11;
                break;
            case 6:
                Heuser_Bereich[0] = 30;
                Heuser_Bereich[1] = 34;
                Heuser_Bereich[2] = 13;
                break;
            case 7:
                Heuser_Bereich[0] = 35;
                Heuser_Bereich[1] = 39;
                Heuser_Bereich[2] = 14;
                break;
            case 8:
                Heuser_Bereich[0] = 40;
                Heuser_Bereich[1] = 44;
                Heuser_Bereich[2] = 16;
                break;
            case 9:
                Heuser_Bereich[0] = 45;
                Heuser_Bereich[1] = 49;
                Heuser_Bereich[2] = 18;
                break;
            case 10:
                Heuser_Bereich[0] = 50;
                Heuser_Bereich[1] = 54;
                Heuser_Bereich[2] = 19;
                break;
            case 11:
                Heuser_Bereich[0] = 55;
                Heuser_Bereich[1] = 59;
                Heuser_Bereich[2] = 21;
                break;
            case 12:
                Heuser_Bereich[0] = 60;
                Heuser_Bereich[1] = 64;
                Heuser_Bereich[2] = 23;
                break;
            case 13:
                Heuser_Bereich[0] = 65;
                Heuser_Bereich[1] = 69;
                Heuser_Bereich[2] = 24;
                break;
            case 15:
                Heuser_Bereich[0] = 70;
                Heuser_Bereich[1] = 74;
                Heuser_Bereich[2] = 26;
                break;
            case 16:
                Heuser_Bereich[0] = 75;
                Heuser_Bereich[1] = 79;
                Heuser_Bereich[2] = 27;
                break;
            case 17:
                Heuser_Bereich[0] = 80;
                Heuser_Bereich[1] = 84;
                Heuser_Bereich[2] = 29;
                break;
            case 18:
                Heuser_Bereich[0] = 85;
                Heuser_Bereich[1] = 89;
                Heuser_Bereich[2] = 31;
                break;
            case 19:
                Heuser_Bereich[0] = 90;
                Heuser_Bereich[1] = 94;
                Heuser_Bereich[2] = 32;
                break;
            case 20:
                Heuser_Bereich[0] = 95;
                Heuser_Bereich[1] = 99;
                Heuser_Bereich[2] = 34;
                break;
            case 21:
                Heuser_Bereich[0] = 100;
                Heuser_Bereich[1] = 104;
                Heuser_Bereich[2] = 37;
                break;
            case 22:
                Heuser_Bereich[0] = 105;
                Heuser_Bereich[1] = 109;
                Heuser_Bereich[2] = 39;
                break;
        }
            Buy_Haus();

    }
    public void Buy_Haus()
    {
        O = 0;
        if (GameManager.Haus_Stufe[Heuser_Bereich[2]] <= 4)
        {
            GameManager.Player_Money[GameManager.Next] -= GameManager.Haus_Kaufpreis[Heuser_Bereich[2]];
            GameManager.Haus_Stufe[Heuser_Bereich[2]] += 1;
            for (int i = Heuser_Bereich[0]; i < Heuser_Bereich[1]; i++)
            {
                O += 1;
                if (GameManager.Haus_Stufe[Heuser_Bereich[2]] > O)
                {
                    Heuser[i].SetActive(true);
                }
                else
                {
                    Heuser[i].SetActive(false);
                }
            }
        }
        GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
    }

    public void Sell_Haus()
    {
        O = 0;
        if (GameManager.Haus_Stufe[Heuser_Bereich[2]] > 0)
        {
            GameManager.Player_Money[GameManager.Next] += GameManager.Haus_Kaufpreis[Heuser_Bereich[2]];
            GameManager.Haus_Stufe[Heuser_Bereich[2]] -= 1;
            for (int i = Heuser_Bereich[0]; i < Heuser_Bereich[1]; i++)
            {
                O += 1;
                if (GameManager.Haus_Stufe[Heuser_Bereich[2]] > O)
                {
                    Heuser[i].SetActive(true);
                }
                else
                {
                    Heuser[i].SetActive(false);
                }
            }
        }
        GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
    }
}
