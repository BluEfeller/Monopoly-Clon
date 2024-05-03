using UnityEngine;
using TMPro;
using System.Collections;
using Unity.VisualScripting;

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
    private GameObject[] Player_Straßen_Besitz_1;

    [SerializeField]
    private GameObject[] Player_Straßen_Besitz_2;

    [SerializeField]
    private GameObject[] Player_Straßen_Besitz_3;

    [SerializeField]
    private GameObject[] Player_Straßen_Besitz_4;

    public GameObject[,] Player_Straßen_Besitz_Insgesamt = new GameObject[4, 40];


    [SerializeField]
    private int[] Player_Positionen;

    [SerializeField]
    private int[] Player_Arten;

    [SerializeField]
    private GameObject[] Player_Figuren;

    [SerializeField]
    private int[] Würfel;

    [SerializeField]
    private GameObject[] Straßen_Karten;

    [SerializeField]
    private GameObject[] Gemeinschafts_Karten;

    [SerializeField]
    private GameObject[] Erreignis_Karten;

    [SerializeField]
    private int[] Kaufs_Preis_Straßen;

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
    private int[] Preis_Auflösung_Hypoteken;

    [SerializeField]
    private int[] Straßen_Besitzer;

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




    private void Start()
    {
        Change_Money_Screen();
        Player_Arten[0] = GameManager.Player_1_Art;
        Player_Arten[1] = GameManager.Player_2_Art;
        Player_Arten[2] = GameManager.Player_3_Art;
        Player_Arten[3] = GameManager.Player_4_Art;
        for (int i = 0; i <= 39; i++) 
        { 
            Straßen_Karten[i].SetActive(false);
            Debug.Log(" Weitere Karte Deaktiviert ");
        }
        for (int i = 0; i <= 15; i++)
        {
            Gemeinschafts_Karten[i].SetActive(false);
            Debug.Log(" Weitere Gemeinschafts Karte Deaktiviert ");
        }
        for (int i = 0; i <= 13; i++)
        {
            Erreignis_Karten[i].SetActive(false);
            Debug.Log(" Weitere Erreignis Karte Deaktiviert ");
        }
        for (int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 40; j++)
            {
                if(i == 0)
                {
                    Player_Positioenen_insgesamt[i, j] = Player_1_Positonen[j];
                }
                else if(i == 1)
                {
                    Player_Positioenen_insgesamt[i, j] = Player_2_Positonen[j];
                }
                else if (i == 2)
                {
                    Player_Positioenen_insgesamt[i, j] = Player_3_Positonen[j];
                }
                else if (i == 3)
                {
                    Player_Positioenen_insgesamt[i, j] = Player_4_Positonen[j];
                }
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 40; j++)
            {
                if (i == 0)
                {
                    Player_Straßen_Besitz_Insgesamt[i, j] = Player_Straßen_Besitz_1[j];
                    Player_Straßen_Besitz_1[j].SetActive(false);

                }
                else if (i == 1)
                {
                    Player_Straßen_Besitz_Insgesamt[i, j] = Player_Straßen_Besitz_2[j];
                    Player_Straßen_Besitz_2[j].SetActive(false);
                }
                else if (i == 2)
                {
                    Player_Straßen_Besitz_Insgesamt[i, j] = Player_Straßen_Besitz_3[j];
                    Player_Straßen_Besitz_3[j].SetActive(false);
                }
                else if (i == 3)
                {
                    Player_Straßen_Besitz_Insgesamt[i, j] = Player_Straßen_Besitz_4[j];
                    Player_Straßen_Besitz_4[j].SetActive(false);
                }
            }
        }
    }


    // this Function is for the dice Rolling
    public void Roll_the_dice()
    {

        if (GameManager.Würfel_Versuch == 0)
        {
            GameManager.Würfel_Versuch = 1;
            //Random Number From 1 to 6
            Würfel[0] = Random.Range(1, 7);
            Würfel[1] = Random.Range(1, 7);
            Gemeinschafts_Kartenzahl = Random.Range(0, 15);
            Erreignis_Kartenzahl = Random.Range(0, 13);

    //test
    //Würfel[0] = 1;
    //Würfel[1] = 0;


            // Checkt watt for a Player 
    Player_Positionen[GameManager.Next] += Würfel[0] + Würfel[1];
                if(Player_Positionen[GameManager.Next] > 39) 
                {
                    Player_Money[GameManager.Next] += 200;
                    Change_Money_Screen();
                }
                Player_Positionen[GameManager.Next] = Player_Positionen[GameManager.Next] % 40;
                Straßen_Karten[Player_Positionen[GameManager.Next]].SetActive(true);

                if (GameObject.Find(Player_Figuren_Namen[GameManager.Next]) == true)
                {
                //Search GameObject for Player 1 and Chanched the Player Model to a other position
                    GameObject.Find(Player_Figuren_Namen[GameManager.Next]).transform.position = new Vector3(Player_Positioenen_insgesamt[GameManager.Next, Player_Positionen[GameManager.Next]].position.x, Player_Positioenen_insgesamt[GameManager.Next, Player_Positionen[GameManager.Next]].position.y, Player_Positioenen_insgesamt[GameManager.Next, Player_Positionen[GameManager.Next]].position.z);
                }
            else if (GameObject.Find(Player_Figuren_Namen[GameManager.Next]+4) == true)
                {
                    // Same in the uper if but Dev Model
                    Debug.Log("Dev Bild");
                GameObject.Find(Player_Figuren_Namen[GameManager.Next+4]).transform.position = new Vector3(Player_Positioenen_insgesamt[GameManager.Next, Player_Positionen[GameManager.Next]].position.x, Player_Positioenen_insgesamt[GameManager.Next, Player_Positionen[GameManager.Next]].position.y, Player_Positioenen_insgesamt[GameManager.Next, Player_Positionen[GameManager.Next]].position.z);
            }
                if(Player_Positionen[GameManager.Next] == 2 || Player_Positionen[GameManager.Next] == 17 || Player_Positionen[GameManager.Next] == 33)
                {
                    Erreignis_Karten[Erreignis_Kartenzahl].SetActive(true);
                }
                else if (Player_Positionen[GameManager.Next] == 7 || Player_Positionen[GameManager.Next] == 22 || Player_Positionen[GameManager.Next] == 36)
                {
                    Gemeinschafts_Karten[Gemeinschafts_Kartenzahl].SetActive(true);
                }
                else if (Player_Positionen[GameManager.Next] == 4)
                {
                    Player_Money[GameManager.Next] -= 200;
                    Change_Money_Screen();
                }
                else if (Player_Positionen[GameManager.Next] == 38)
                {
                    Player_Money[GameManager.Next] -= 100;
                    Change_Money_Screen();
                }
                else
                {
                    if (Player_Positionen[GameManager.Next] == 12 || Player_Positionen[GameManager.Next] == 28)
                    {
                        if (Frei[12] == Frei[28])
                        {
                            Unbebaut[12] = Würfel[0] + Würfel[1] * 10;
                            Unbebaut[28] = Würfel[0] + Würfel[1] * 10;
                        }
                        else
                        {
                            Unbebaut[12] = Würfel[0] + Würfel[1] * 4;
                            Unbebaut[28] = Würfel[0] + Würfel[1] * 4;
                        }
                    }
                    Kaufpaar();
                }
                if (Player_Arten[GameManager.Next] == 1)
                {
                    Invoke("Next_Player",1f);
                }

        }
    }

    public void Kaufpaar()
    {
        if ( 0 == 1)
        {

        }
        else if (Player_Arten[GameManager.Next] == 1)
        {
            if (Frei[Player_Positionen[GameManager.Next]] == -1)
            {
                int AutoKauf = Random.Range(0, 100);
                //int AutoKauf = 55;
                if (AutoKauf < 50)
                {

                }
                else if (Player_Money[GameManager.Next] >= Kaufs_Preis_Straßen[Player_Positionen[GameManager.Next]])
                {
                    Frei[Player_Positionen[GameManager.Next]] = GameManager.Next;
                    Player_Money[GameManager.Next] -= Kaufs_Preis_Straßen[Player_Positionen[GameManager.Next]];
                    Player_Straßen_Besitz_Insgesamt[GameManager.Next, Player_Positionen[GameManager.Next]].SetActive(true);
                    Change_Money_Screen();
                    Debug.Log("Setzt Karte " + Frei[Player_Positionen[GameManager. Next]] + " Zu Spieler " + GameManager.Next);
                    if (Player_Positionen[GameManager.Next] == 5 || Player_Positionen[GameManager.Next] == 15 || Player_Positionen[GameManager.Next] == 25 || Player_Positionen[GameManager.Next] == 35)
                    {
                        Bahnhofs_Besitz[GameManager.Next] += 1;
                        if (Bahnhofs_Besitz[GameManager.Next] == 2)
                        {
                            if (Frei[5] == GameManager.Next) { BauStufe[5] = 1; }
                            if (Frei[15] == GameManager.Next) { BauStufe[15] = 1; }
                            if (Frei[25] == GameManager.Next) { BauStufe[25] = 1; }
                            if (Frei[35] == GameManager.Next) { BauStufe[35] = 1; }
                        }
                        else if (Bahnhofs_Besitz[GameManager.Next] == 3)
                        {
                            if (Frei[5] == GameManager.Next) { BauStufe[5] = 2; }
                            if (Frei[15] == GameManager.Next) { BauStufe[15] = 2; }
                            if (Frei[25] == GameManager.Next) { BauStufe[25] = 2; }
                            if (Frei[35] == GameManager.Next) { BauStufe[35] = 2; }
                        }
                        else if (Bahnhofs_Besitz[GameManager.Next] == 4)
                        {
                            if (Frei[5] == GameManager.Next) { BauStufe[5] = 3; }
                            if (Frei[15] == GameManager.Next) { BauStufe[15] = 3; }
                            if (Frei[25] == GameManager.Next) { BauStufe[25] = 3; }
                            if (Frei[35] == GameManager.Next) { BauStufe[35] = 3; }
                        }
                    }
                }
            }
            else
            {
                if (BauStufe[Player_Positionen[GameManager.Next]] == 0 )
                {
                    Player_Money[GameManager.Next] -= Unbebaut[Player_Positionen[GameManager.Next]];
                    Player_Money[Frei[Player_Positionen[GameManager.Next]]] += Unbebaut[Player_Positionen[GameManager.Next]];
                    Change_Money_Screen();
                }
                else if(BauStufe[Player_Positionen[GameManager.Next]] == 1)
                {
                    Player_Money[GameManager.Next] -= Haus_1[Player_Positionen[GameManager.Next]];
                    Player_Money[Frei[Player_Positionen[GameManager.Next]]] += Haus_1[Player_Positionen[GameManager.Next]];
                    Change_Money_Screen();
                }
                else if (BauStufe[Player_Positionen[GameManager.Next]] == 2)
                {
                    Player_Money[GameManager.Next] -= Haus_2[Player_Positionen[GameManager.Next]];
                    Player_Money[Frei[Player_Positionen[GameManager.Next]]] += Haus_2[Player_Positionen[GameManager.Next]];
                    Change_Money_Screen();
                }
                else if (BauStufe[Player_Positionen[GameManager.Next]] == 3)
                {
                    Player_Money[GameManager.Next] -= Haus_3[Player_Positionen[GameManager.Next]];
                    Player_Money[Frei[Player_Positionen[GameManager.Next]]] += Haus_3[Player_Positionen[GameManager.Next]];
                    Change_Money_Screen();
                }
                else if (BauStufe[Player_Positionen[GameManager.Next]] == 4)
                {
                    Player_Money[GameManager.Next] -= Haus_4[Player_Positionen[GameManager.Next]];
                    Player_Money[Frei[Player_Positionen[GameManager.Next]]] += Haus_4[Player_Positionen[GameManager.Next]];
                    Change_Money_Screen();
                }
                else if (BauStufe[Player_Positionen[GameManager.Next]] == 5)
                {
                    Player_Money[GameManager.Next] -= Hotel[Player_Positionen[GameManager.Next]];
                    Player_Money[Frei[Player_Positionen[GameManager.Next]]] += Hotel[Player_Positionen[GameManager.Next]];
                    Change_Money_Screen();
                }
            }
        }
    }


    public void Gemeinschafts_Karte_Erreignise()
    {
        if (Gemeinschafts_Kartenzahl == 0)
        {
            Player_Money[GameManager.Next] += 400;
            Player_Money[0] -= 100;
            Player_Money[1] -= 100;
            Player_Money[2] -= 100;
            Player_Money[3] -= 100;
        }
        else if (Gemeinschafts_Kartenzahl == 1)
        {
            Player_Money[GameManager.Next] += 5;
        }
        else if (Gemeinschafts_Kartenzahl == 2)
        {
            Player_Money[GameManager.Next] += 200;
        }
        else if (Gemeinschafts_Kartenzahl == 3)
        {
            Player_Money[GameManager.Next] += 10;
        }
        else if (Gemeinschafts_Kartenzahl == 4)
        {
            Player_Money[GameManager.Next] += 5;
        }
        else if (Gemeinschafts_Kartenzahl == 5)
        {




        }
        else if (Gemeinschafts_Kartenzahl == 6)
        {



        }
        else if (Gemeinschafts_Kartenzahl == 7)
        {
            Player_Money[GameManager.Next] += 200;
        }
        else if (Gemeinschafts_Kartenzahl == 8)
        {
            Player_Money[GameManager.Next] += 200;
        }
        else if (Gemeinschafts_Kartenzahl == 9)
        {
            Player_Money[GameManager.Next] += 25;
        }
        else if (Gemeinschafts_Kartenzahl == 10)
        {




        }
        else if (Gemeinschafts_Kartenzahl == 11)
        {




        }
        else if (Gemeinschafts_Kartenzahl == 12)
        {




        }
        else if (Gemeinschafts_Kartenzahl == 13)
        {
            Player_Money[GameManager.Next] -= 200;
        }
        else if (Gemeinschafts_Kartenzahl == 14)
        {
            Player_Money[GameManager.Next] -= 50;
        }
        else if (Gemeinschafts_Kartenzahl == 15)
        {
            Player_Money[GameManager.Next] += 100;
        }
    }
    

    public void Change_Money_Screen()
    {
        GameManager.Player_1_Geld = Player_Money[0];
        GameManager.Player_2_Geld = Player_Money[1];
        GameManager.Player_3_Geld = Player_Money[2];
        GameManager.Player_4_Geld = Player_Money[3];
        Money_Text[0].text = GameManager.Player_1_Geld + "€";
        Money_Text[1].text = GameManager.Player_2_Geld + "€";
        Money_Text[2].text = GameManager.Player_3_Geld + "€";
        Money_Text[3].text = GameManager.Player_4_Geld + "€";
        Money_Text[4].text = "Spieler " + GameManager.Next + " Tran";
    }

    public void Next_Player()
    {
        for (int i = 0; i <= 39; i++)
        {
            Straßen_Karten[i].SetActive(false);
            Debug.Log(" Weitere Karte Deaktiviert ");
        }
        for (int i = 0; i <= 15; i++)
        {
            Gemeinschafts_Karten[i].SetActive(false);
            Debug.Log(" Weitere Gemeinschafts Karte Deaktiviert ");
        }
        for (int i = 0; i <= 13; i++)
        {
            Erreignis_Karten[i].SetActive(false);
            Debug.Log(" Weitere Erreignis Karte Deaktiviert ");
        }
        GameManager.Würfel_Versuch = 0;
        GameManager.Next ++;
        GameManager.Next = GameManager.Next % 4;

        if (Player_Arten[GameManager.Next] == 1)
        {
            Invoke("Roll_the_dice", 1f);
        }

        Money_Text[4].text = "Spieler " + GameManager.Next + " Tran";
    }
}
