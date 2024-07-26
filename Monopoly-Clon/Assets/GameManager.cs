using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Lobby Variablen
    public static int Bot_Change;
    public static int Player_Change;
    public static Transform[,] Player_Positioenen_insgesamt = new Transform[4, 40];
    public static int Geschlossen_Change;
    public static int[] W¸rfel = new int[2];
    public static int Gemeinschafts_Zahlen;
    public static GameObject[] Gemeinschafts_Karten = new GameObject[16];
    public static int Erreignis_Kartenzahl;
    public static GameObject[] Erreignis_Karten = new GameObject[14];
    public static string[] Player_Figure_Namen = { "Player_1", "Player_2", "Player_3", "Player_4", "Player_1_Dev", "Player_2_Dev", "Player_3_Dev", "Player_4_Dev" };
    public static int[] Player_Arten = { 2, 2, 2, 2 };
    public static int[] Player_Positionen = { 0, 0, 0, 0 };
    public static int[] Straﬂen_Kaufpreise = new int[40];
    public static GameObject[] Straﬂen_Karten = new GameObject[40];
    public static int[,] Straﬂen_Hypoteken = new int[2, 40];
    public static int[] Offene_Hypoteken = new int[40];
    public static int[] Freie_Straﬂen = new int[40];
    public static GameObject[,] Player_Straﬂen_Besitz_Anzeige = new GameObject[4, 40];
    public static int[] Haus_Stufe = new int[40];
    public static int[] Haus_Kaufpreis = new int[40];
    public static int[] Bahnhofs_Besitz = new int[4];
    public static int[,] Haus_Stufen_Mietpreise = new int[6,40];
    public static int[] Player_Money = { 1000, 1000, 1000, 1000 };
    public static int[] Gef‰ngnis = { 0, 0, 0, 0 };
    public static int[] Gef‰ngnis_Freikarten = { 0, 0, 0, 0 };

                

    //Im Spiel

    public static int W¸rfel_Versuch = 0;
    public static int Next = 0;
    public static int Current_Sceen = 0;



    // Stets Player 1
    public static string Player_1_Name;
    public static int Player_1_Art = 1;
    public static int Player_1_Figurnummer;
    public static int Player_1_Feld = 0;
    public static int player_1_Aktuelles_Feld = 0;


    // Stets Player 2
    public static string Player_2_Name;
    public static int Player_2_Art = 1;
    public static int Player_2_Figurnummer;
    public static int Player_2_Feld = 0;
    public static int player_2_Aktuelles_Feld = 0;


    // Stets Player 3
    public static string Player_3_Name;
    public static int Player_3_Art = 1;
    public static int Player_3_Figurnummer;
    public static int Player_3_Feld = 0;
    public static int player_3_Aktuelles_Feld = 0;


    // Stets Player 4
    public static string Player_4_Name;
    public static int Player_4_Art = 1;
    public static int Player_4_Figurnummer;
    public static int Player_4_Feld = 0;
    public static int player_4_Aktuelles_Feld = 0;
}
