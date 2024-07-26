using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trade_HUB : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Alles;

    [SerializeField]
    private GameObject[] Aktueller_Trader;
    [SerializeField]
    private GameObject[] Aktueller_Trader_Ausgewelten;

    [SerializeField]
    private GameObject[] Trade_Partner;
    [SerializeField]
    private GameObject[] Trade_Partner_Ausgewelten;

    [SerializeField]
    private GameObject[] Schatten;

    [SerializeField]
    private GameObject[] Button_Trade_Partner_wahl;

    [SerializeField]
    private int Übersetzer = 0;

    [SerializeField]
    private int[] Handels_Speicher;

    [SerializeField]
    private int[] Aktiver_Button_Aktueller_Nutzer = new int[28];

    [SerializeField]
    private int[] Aktiver_button_Trade_Nutzer = new int[28];
    [SerializeField]
    private int Partern_Number = 0;

    [SerializeField]
    private TMP_InputField[] Convertet;

    [SerializeField]
    private int[] Input_Int;

    [SerializeField]
    private bool[] Trade_Ready;

    [SerializeField]
    private GameObject[] Ready_Anzeige;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 28; i++)
        {
            Aktueller_Trader_Ausgewelten[i].SetActive(false);
            Trade_Partner_Ausgewelten[i].SetActive(false);
        }
        for (int i = 0; i < 40; i++)
        {
            Aktueller_Trader[i].SetActive(false);
            Trade_Partner[i].SetActive(false);
        }
        for (int i= 0; i < 39; i++)
        {

            Handels_Speicher[i] = -1;
        }
        for (int i = 0; i < 112; i++)
        {
            Schatten[i].SetActive(false);
        }

    }

    public void Handel_Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Ready_Anzeige[i].SetActive(false);
            Alles[i].SetActive(false);
            Debug.Log(GameManager.Next);
            if (GameManager.Next == i)
            {
                Button_Trade_Partner_wahl[i].SetActive(false);
            }
            else
            {
                Button_Trade_Partner_wahl[i].SetActive(true);
            }
        }
    }
    public void Handel_Aufbauen(int Auserwehlter)
    {

        Ready_Anzeige[1].SetActive(true);
        Ready_Anzeige[3].SetActive(true);
        Alles[0].SetActive(true);
        Alles[1].SetActive(true);
        Alles[2].SetActive(true);
        Alles[3].SetActive(true);
        for (int i = 0; i < 112; i++)
        {
            Schatten[i].SetActive(true);
        }
        for (int i = 0; i < 4; i++)
        {
            Button_Trade_Partner_wahl[i].SetActive(false);
        }
        for (int i = 0; i < 28; i++)
        {
            if (GameManager.Freie_Straßen[i] == GameManager.Next)
            {
                Aktueller_Trader[i].SetActive(true);
            }
            else
            {
                Aktueller_Trader[i].SetActive(false);
            }
            if (GameManager.Freie_Straßen[i] == Auserwehlter)
            {
                Trade_Partner[i].SetActive(true);
            }
            else
            {
                Trade_Partner[i].SetActive(false);
            }
        }
        Partern_Number = Auserwehlter;
    }
    public void Handel_Auswahl(int Wiewatt)
    {
        switch (Wiewatt)
        {
            case 1:
                Übersetzer = 0;
                break;
            case 3:
                Übersetzer = 1;
                break;
            case 5:
                Übersetzer = 2;
                break;
            case 6:
                Übersetzer = 3;
                break;
            case 8:
                Übersetzer = 4;
                break;
            case 9:
                Übersetzer = 5;
                break;
            case 11:
                Übersetzer = 6;
                break;
            case 12:
                Übersetzer = 7;
                break;
            case 13:
                Übersetzer = 8;
                break;
            case 14:
                Übersetzer = 9;
                break;
            case 15:
                Übersetzer = 10;
                break;
            case 16:
                Übersetzer = 11;
                break;
            case 18:
                Übersetzer = 12;
                break;
            case 19:
                Übersetzer = 13;
                break;
            case 21:
                Übersetzer = 14;
                break;
            case 23:
                Übersetzer = 15;
                break;
            case 24:
                Übersetzer = 16;
                break;
            case 25:
                Übersetzer = 17;
                break;
            case 26:
                Übersetzer = 18;
                break;
            case 27:
                Übersetzer = 19;
                break;
            case 28:
                Übersetzer = 20;
                break;
            case 29:
                Übersetzer = 21;
                break;
            case 31:
                Übersetzer = 22;
                break;
            case 32:
                Übersetzer = 23;
                break;
            case 34:
                Übersetzer = 24;
                break;
            case 35:
                Übersetzer = 25;
                break;
            case 37:
                Übersetzer = 26;
                break;
            case 39:
                Übersetzer = 27;
                break;
        }
        if (Aktiver_Button_Aktueller_Nutzer[Übersetzer] == 1)
        {
            Aktiver_Button_Aktueller_Nutzer[Übersetzer] = 0;
            Aktueller_Trader_Ausgewelten[Übersetzer].SetActive(false);
            Handels_Speicher[Wiewatt] = -1;
        }
        else
        {
            Aktiver_Button_Aktueller_Nutzer[Übersetzer] = 1;
            Aktueller_Trader_Ausgewelten[Übersetzer].SetActive(true);
            Handels_Speicher[Wiewatt] = GameManager.Next;
        }
    }

    public void Handel_Auswahl_2(int Wiewatt)
    {
        switch (Wiewatt)
        {
            case 1:
                Übersetzer = 0;
                break;
            case 3:
                Übersetzer = 1;
                break;
            case 5:
                Übersetzer = 2;
                break;
            case 6:
                Übersetzer = 3;
                break;
            case 8:
                Übersetzer = 4;
                break;
            case 9:
                Übersetzer = 5;
                break;
            case 11:
                Übersetzer = 6;
                break;
            case 12:
                Übersetzer = 7;
                break;
            case 13:
                Übersetzer = 8;
                break;
            case 14:
                Übersetzer = 9;
                break;
            case 15:
                Übersetzer = 10;
                break;
            case 16:
                Übersetzer = 11;
                break;
            case 18:
                Übersetzer = 12;
                break;
            case 19:
                Übersetzer = 13;
                break;
            case 21:
                Übersetzer = 14;
                break;
            case 23:
                Übersetzer = 15;
                break;
            case 24:
                Übersetzer = 16;
                break;
            case 25:
                Übersetzer = 17;
                break;
            case 26:
                Übersetzer = 18;
                break;
            case 27:
                Übersetzer = 19;
                break;
            case 28:
                Übersetzer = 20;
                break;
            case 29:
                Übersetzer = 21;
                break;
            case 31:
                Übersetzer = 22;
                break;
            case 32:
                Übersetzer = 23;
                break;
            case 34:
                Übersetzer = 24;
                break;
            case 35:
                Übersetzer = 25;
                break;
            case 37:
                Übersetzer = 26;
                break;
            case 39:
                Übersetzer = 27;
                break;
        }
        if (Aktiver_button_Trade_Nutzer[Übersetzer] == 1)
        {
            Aktiver_button_Trade_Nutzer[Übersetzer] = 0;
            Trade_Partner_Ausgewelten[Übersetzer].SetActive(false);
            Handels_Speicher[Wiewatt] = -1;
        }
        else
        {
            Aktiver_button_Trade_Nutzer[Übersetzer] = 1;
            Trade_Partner_Ausgewelten[Übersetzer].SetActive(true);
            Handels_Speicher[Wiewatt] = Partern_Number;
        }

    }

    public void Give_Trade_Money(int lol)
    {
        Input_Int[0] = int.Parse(Convertet[0].text);
    }
    public void Give_Auserwelter_Money(int lol)
    {
        Input_Int[1] = int.Parse(Convertet[1].text);
    }

    public void Trader_Ready(int Person)
    {
        if (Trade_Ready[0] == true && Person == 0)
        {
            Trade_Ready[0] = false;
            Ready_Anzeige[0].SetActive(false);

            Ready_Anzeige[1].SetActive(true);
            Ready_Anzeige[0].SetActive(false);

        }
        else if (Trade_Ready[0] == false && Person == 0) 
        {
            Trade_Ready[0] = true;
            Ready_Anzeige[0].SetActive(true);
            Ready_Anzeige[1].SetActive(false);
        }

        if (Trade_Ready[1] == true && Person == 1)
        {
            Trade_Ready[1] = false;
            Ready_Anzeige[3].SetActive(true);
            Ready_Anzeige[2].SetActive(false);

        }
        else if (Trade_Ready[1] == false && Person == 1)
        {
            Trade_Ready[1] = true;
            Ready_Anzeige[3].SetActive(false);
            Ready_Anzeige[2].SetActive(true);

        }

        if (Trade_Ready[0] == true && Trade_Ready[1] == true)
        {
            Execute_Order_66();
        }
    }

    public void Execute_Order_66()
    {
        for (int i = 0; i < 39; i++)
        {
            if (Handels_Speicher[i] == -1)
            {

            }
            else
            {

                Debug.Log("alter Stand " + GameManager.Freie_Straßen[i]);
                GameManager.Freie_Straßen[i] = Handels_Speicher[i];
                Debug.Log("Neurstand " + GameManager.Freie_Straßen[i]);
                if (GameManager.Freie_Straßen[i] == GameManager.Next)
                {
                    GameManager.Player_Straßen_Besitz_Anzeige[GameManager.Next, i].SetActive(true);
                }
                else
                {
                    GameManager.Player_Straßen_Besitz_Anzeige[GameManager.Next, i].SetActive(false);
                }
                if (GameManager.Freie_Straßen[i] == Partern_Number)
                {
                    GameManager.Player_Straßen_Besitz_Anzeige[Partern_Number, i].SetActive(true);
                }
                else
                {
                    GameManager.Player_Straßen_Besitz_Anzeige[Partern_Number, i].SetActive(false);
                }
            }
        }
        GameManager.Player_Money[GameManager.Next] += Input_Int[1];
        GameManager.Player_Money[Partern_Number] += Input_Int[0];
        GameManager.Player_Money[GameManager.Next] -= Input_Int[0];
        GameManager.Player_Money[Partern_Number] -= Input_Int[1];

        for (int i = 0; i < 28; i++)
        {
            Aktueller_Trader_Ausgewelten[i].SetActive(false);
            Trade_Partner_Ausgewelten[i].SetActive(false);
        }
        for (int i = 0; i < 40; i++)
        {
            Aktueller_Trader[i].SetActive(false);
            Trade_Partner[i].SetActive(false);
        }
        for (int i = 0; i < 39; i++)
        {

            Handels_Speicher[i] = -1;
        }
        for (int i = 0; i < 112; i++)
        {
            Schatten[i].SetActive(false);
        }
        Handel_Start();
    }


}
