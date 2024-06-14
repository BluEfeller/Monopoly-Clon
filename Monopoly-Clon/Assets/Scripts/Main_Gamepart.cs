using UnityEngine;
using TMPro;

public class Main_Gamepart : MonoBehaviour
{
    private int Gemeinschafts_Kartenzahl;
    private int Erreignis_Kartenzahl;

    [SerializeField]
    private Transform[] Player_1_Positonen;

    [SerializeField]
    private Transform[] Player_2_Positonen;

    [SerializeField]
    private Transform[] Player_3_Positonen;

    [SerializeField]
    private Transform[] Player_4_Positonen;

    public Transform[,] Player_Positioenen_insgesamt = new Transform[4, 40];

    [SerializeField]
    private GameObject[] Player_Stra�en_Besitz_1;

    [SerializeField]
    private GameObject[] Player_Stra�en_Besitz_2;

    [SerializeField]
    private GameObject[] Player_Stra�en_Besitz_3;

    [SerializeField]
    private GameObject[] Player_Stra�en_Besitz_4;

    public GameObject[,] Player_Stra�en_Besitz_Insgesamt = new GameObject[4, 40];


    [SerializeField]
    private int[] Player_Positionen;

    [SerializeField]
    private int[] Player_Arten;

    [SerializeField]
    private GameObject[] Player_Figuren;

    [SerializeField]
    private int[] W�rfel;

    [SerializeField]
    private GameObject[] Stra�en_Karten;

    [SerializeField]
    private GameObject[] Gemeinschafts_Karten;

    [SerializeField]
    private GameObject[] Erreignis_Karten;

    [SerializeField]
    private int[] Kaufs_Preis_Stra�en;

    [SerializeField]
    private int[] Unbebaut;

    [SerializeField]
    private int[] Haus_1;

    [SerializeField]
    private int[] Haus_2;

    [SerializeField]
    private int[] Haus_3;

    [SerializeField]
    private int[] Haus_4;

    [SerializeField]
    private int[] Hotel;

    [SerializeField]
    private int[] Preis_Hauser;

    [SerializeField]
    private int[] Bahnhofs_Besitz;

    [SerializeField]
    private int[] BauStufe;

    [SerializeField]
    private int[] Preis_Hypoteken;

    [SerializeField]
    private int[] Preis_Aufl�sung_Hypoteken;

    [SerializeField]
    private int[] Stra�en_Besitzer;

    [SerializeField]
    private int[] Frei;

    [SerializeField]
    private int[] Player_Money;

    [SerializeField]
    private TMP_Text[] Money_Text;

    [SerializeField]
    private string[] Player_Figuren_Namen;

    [SerializeField]
    private int[] Handels_Wert;

    [SerializeField]
    private int[] Gef�ngnis;

    [SerializeField]
    private int[] FreiKarten;

    [SerializeField]
    private TMP_Text[] Frei_Karten_Anzeige;

    [SerializeField]
    private GameObject WHY;

    [SerializeField]
    private int[] Reno_Kosten;




    private void Start()
    {
        int z = 4;
        int ii = 4;
        if(ii > 0)
        {
            z = z + 4;
            z = z / ii;
            ii = ii - 1;
        }
        Debug.Log(z);
        for (int i = 0; i <= 3; i++)
        {
            GameManager.Gef�ngnis[i] = 0;
            GameManager.Gef�ngnis_Freikarten[i] = 0;
            GameManager.Player_Money[i] = 1000;
            GameManager.Bahnhofs_Besitz[i] = 0;
            GameManager.Player_Positionen[i] = 0;
        }
        for (int i = 0; i < 4; i++)
        {
            GameManager.Player_Money[i] = Player_Money[i];
            Money_Text[i].text = GameManager.Player_Money[i] + "�";
        }
        Money_Text[4].text = "Spieler " + GameManager.Next + " Dran";
        WHY.SetActive(false);
        for (int i = 0; i <= 39; i++)
        {
            GameManager.Stra�en_Karten[i] = Stra�en_Karten[i];
            GameManager.Stra�en_Karten[i].SetActive(false);
            GameManager.Freie_Stra�en[i] = -1;
        }
        for (int i = 0; i <= 15; i++)
        {
            Gemeinschafts_Karten[i].SetActive(false);
            GameManager.Gemeinschafts_Karten[i] = Gemeinschafts_Karten[i];
        }
        for (int i = 0; i <= 13; i++)
        {
            Erreignis_Karten[i].SetActive(false);
            GameManager.Erreignis_Karten[i] = Erreignis_Karten[i];
        }
        for (int i = 0; i <39; i++)
        {
            GameManager.Stra�en_Kaufpreise[i] = Kaufs_Preis_Stra�en[i];
            GameManager.Haus_Stufen_Mietpreise[0, i] = Unbebaut[i];
            GameManager.Haus_Stufen_Mietpreise[1, i] = Haus_1[i];
            GameManager.Haus_Stufen_Mietpreise[2, i] = Haus_2[i];
            GameManager.Haus_Stufen_Mietpreise[3, i] = Haus_3[i];
            GameManager.Haus_Stufen_Mietpreise[4, i] = Haus_4[i];
            GameManager.Haus_Stufen_Mietpreise[5, i] = Hotel[i];
            GameManager.Haus_Stufe[i] = 0;
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 40; j++)
            {
                switch (i)
                {
                    case 0:
                        GameManager.Player_Positioenen_insgesamt[i, j] = Player_1_Positonen[j];
                        GameManager.Player_Stra�en_Besitz_Anzeige[i, j] = Player_Stra�en_Besitz_1[j];
                        Player_Stra�en_Besitz_1[j].SetActive(false);
                        break;
                    case 1:
                        GameManager.Player_Positioenen_insgesamt[i, j] = Player_2_Positonen[j];
                        GameManager.Player_Stra�en_Besitz_Anzeige[i, j] = Player_Stra�en_Besitz_2[j];
                        Player_Stra�en_Besitz_2[j].SetActive(false);
                        break;
                    case 2:
                        GameManager.Player_Positioenen_insgesamt[i, j] = Player_3_Positonen[j];
                        GameManager.Player_Stra�en_Besitz_Anzeige[i, j] = Player_Stra�en_Besitz_3[j];
                        Player_Stra�en_Besitz_3[j].SetActive(false);
                        break;
                    case 3:
                        GameManager.Player_Positioenen_insgesamt[i, j] = Player_4_Positonen[j];
                        GameManager.Player_Stra�en_Besitz_Anzeige[i, j] = Player_Stra�en_Besitz_4[j];
                        Player_Stra�en_Besitz_4[j].SetActive(false);
                        break;
                }
            }
        }
        Ready();
    }
    public void Ready()
    {
        Debug.Log("Ready to Start");
    }

    public void Change_Money_Screen()
    {
        for (int i = 0; i < 4; i++)
        {
            Money_Text[i].text = GameManager.Player_Money[i] + "�";
        }
        Money_Text[4].text = "Spieler " + GameManager.Next + " Dran";
    }
    
    public void Wait_Next()
    {
        if (GameManager.Player_Arten[GameManager.Next] == 1)
        {
            Invoke("Next_Player", 1f);
        }
    }

    public void Next_Player()
    {

        for (int i = 0; i <= 39; i++)
        {
            GameManager.Stra�en_Karten[i].SetActive(false);
        }
        for (int i = 0; i <= 15; i++)
        {
            GameManager.Gemeinschafts_Karten[i].SetActive(false);
        }
        for (int i = 0; i <= 13; i++)
        {
            GameManager.Erreignis_Karten[i].SetActive(false);
        }
        GameManager.W�rfel_Versuch = 0;
        GameManager.Next ++;
        GameManager.Next = GameManager.Next % 4;

        if (GameManager.Player_Arten[GameManager.Next] == 1)
        {
            Invoke("Bot_Roll", 1f);
            
        }
        Money_Text[4].text = "Spieler " + GameManager.Next + " Dran";
    }
    public void Bot_Roll()
    {
        GameObject.Find("W�rfeln").GetComponent<W�rfeln>().Roll_the_Dice();
    }
}
