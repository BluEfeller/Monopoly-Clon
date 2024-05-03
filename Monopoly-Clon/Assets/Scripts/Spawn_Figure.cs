using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using System.Security.Principal;
using UnityEngine.SceneManagement;
using TMPro;

public class Spawn_Figure : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Figur;
    //Array für die Figuren um Diese zu laden

    [SerializeField]
    private string[] Figur_Namen;
    //Array für die Spawn namen wie die Spawnen umd diese dan umzubenenen

    [SerializeField]
    private Transform[] Player_Spawn_Position_Lobby;

    [SerializeField]
    private GameObject[] Player_1_Lobby_Objects;

    [SerializeField]
    private GameObject[] Player_2_Lobby_Objects;

    [SerializeField]
    private GameObject[] Player_3_Lobby_Objects;

    [SerializeField]
    private GameObject[] Player_4_Lobby_Objects;

    [SerializeField]
    private TextMeshProUGUI[] Bot_Player_name;

    [SerializeField]
    private GameObject[] Aktivat_Deaktivate;

    [SerializeField]
    private string[] Bot_Names;


    public int[] Figure_nummer = { 0, 0, 0, 0 };
    //Welche Figur/Name Gerade Festgelegt Würde für alle 4 Spieler




    private void Start()
    {
        GameManager.Player_3_Art = 1;
    }
    public void Change_Bot()
    {
        // Aktivirt oder Deaktiviert Objekte für Bot
        Figure_nummer[GameManager.Bot_Change] = Random.Range(0, 11);
        if      (GameManager.Bot_Change == 0) { Load_Player_1(); Bot_Player_name[0].text = Bot_Names[Random.Range(0, Bot_Names.Length)]; }
        else if (GameManager.Bot_Change == 1) { Load_Player_2(); Bot_Player_name[1].text = Bot_Names[Random.Range(0, Bot_Names.Length)]; }
        else if (GameManager.Bot_Change == 2) { Load_Player_3(); Bot_Player_name[2].text = Bot_Names[Random.Range(0, Bot_Names.Length)]; }
        else if (GameManager.Bot_Change == 3) { Load_Player_4(); Bot_Player_name[3].text = Bot_Names[Random.Range(0, Bot_Names.Length)]; }
        Aktivat_Deaktivate[0].SetActive(false);
        Aktivat_Deaktivate[1].SetActive(false);
        Aktivat_Deaktivate[2].SetActive(false);
        Aktivat_Deaktivate[3].SetActive(false);
        Aktivat_Deaktivate[4].SetActive(true);
        Instantiate(Figur[Figure_nummer[GameManager.Bot_Change]], Player_Spawn_Position_Lobby[GameManager.Bot_Change].position, Quaternion.identity);
        if (GameObject.Find("Player_"+ GameManager.Bot_Change) == true)
        {
            //Schaut ob Player 1 zu finden ist und Zerstört diesen
            Destroy(GameObject.Find("Player_"+ GameManager.Bot_Change));
        }
        if (GameObject.Find(Figur_Namen[Figure_nummer[GameManager.Bot_Change]]) == true)
        {
            //Schaut ob das Object mit dem Namen zu Finden ist und nennt es um
            GameObject.Find(Figur_Namen[Figure_nummer[GameManager.Bot_Change]]).name = "Player_"+GameManager.Bot_Change;
            Debug.Log("Spawn Name Changed");
        }

    }
    private void Change_Player()
    {
        // Aktivirt oder Deaktiviert Objekte für Spieler
        if      (GameManager.Player_Change == 0) { Load_Player_1(); Bot_Player_name[0].text = ""; }
        else if (GameManager.Player_Change == 1) { Load_Player_2(); Bot_Player_name[1].text = ""; }
        else if (GameManager.Player_Change == 2) { Load_Player_3(); Bot_Player_name[2].text = ""; }
        else if (GameManager.Player_Change == 3) { Load_Player_4(); Bot_Player_name[3].text = ""; }
        Aktivat_Deaktivate[0].SetActive(true);
        Aktivat_Deaktivate[1].SetActive(true);
        Aktivat_Deaktivate[2].SetActive(true);
        Aktivat_Deaktivate[3].SetActive(true);
        Aktivat_Deaktivate[4].SetActive(false);
    }
    private void Change_Geschlossen()
    {
        // Deaktiviert den Jewaligen Spieler Tab
        if      (GameManager.Geschlossen_Change == 0) { Load_Player_1(); Bot_Player_name[0].text = ""; }
        else if (GameManager.Geschlossen_Change == 1) { Load_Player_2(); Bot_Player_name[1].text = ""; }
        else if (GameManager.Geschlossen_Change == 2) { Load_Player_3(); Bot_Player_name[2].text = ""; }
        else if (GameManager.Geschlossen_Change == 3) { Load_Player_4(); Bot_Player_name[3].text = ""; }
        Aktivat_Deaktivate[0].SetActive(false);
        Aktivat_Deaktivate[1].SetActive(false);
        Aktivat_Deaktivate[2].SetActive(false);
        Aktivat_Deaktivate[3].SetActive(false);
        Aktivat_Deaktivate[4].SetActive(false);
        if (GameObject.Find("Player_" + GameManager.Player_Change) == true)
        {
            //Schaut ob Player 1 zu finden ist und Zerstört diesen
            Destroy(GameObject.Find("Player_" + GameManager.Player_Change));
        }
    }

    //Player 1
    public void Next_Spawn_Figur_1() //Function um die Nächste Figur anzuzeigen zu lassen
    {
            if (GameObject.Find("Player_0") == true) 
            {
                //Schaut ob Player 1 zu finden ist und Zerstört diesen
                Destroy(GameObject.Find("Player_0"));
            }
            //Zehlt im Array um eine Stelle hoch
            Figure_nummer[0]++;
            if (Figure_nummer[0] > 11)
            {
                //Schaut ob es es Über eine Bestimmte Zahl ist und Setzt sich dan auch 0 Zurück
                Figure_nummer[0] = 0;
            }
            //Spawnd eine Neue Figur mit der Jewalligen Nummer und setzt Diese auch an die Richtig Position
            Instantiate(Figur[Figure_nummer[0]], Player_Spawn_Position_Lobby[0].position, Quaternion.identity);


            if (GameObject.Find(Figur_Namen[Figure_nummer[0]]) == true)
            {
                //Schaut ob das Object mit dem Namen zu Finden ist und nennt es um
                GameObject.Find(Figur_Namen[Figure_nummer[0]]).name = "Player_0";
            }
    }


    public void Last_Spawn_Figur_1()
    {

        Figure_nummer[0]--;
        if (Figure_nummer[0] < 0)
        {
            Figure_nummer[0] = 11;
        }
        Instantiate(Figur[Figure_nummer[0]], Player_Spawn_Position_Lobby[0].position, Quaternion.identity);
        if (GameObject.Find("Player_0") == true)
        {
            Destroy(GameObject.Find("Player_0"));
        }
        if (GameObject.Find(Figur_Namen[Figure_nummer[0]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[0]]).name = "Player_0";
        }
    }
    public void Player_1_DropDown(int Selec)
    {
        GameManager.Player_1_Art = Selec;
        if (Selec == 1)
        {
            GameManager.Bot_Change = 0;
            GameManager.Player_1_Art = 1;
            Change_Bot();
        }
        else if(Selec == 0)
        {
            GameManager.Player_Change = 0;
            GameManager.Player_1_Art = 2;
            Change_Player();
        }
        else if( Selec == 2)
        {
            GameManager.Geschlossen_Change = 0;
            GameManager.Player_1_Art = 3;
            Change_Geschlossen();
        }
    }

    //Player 2
    public void Next_Spawn_Figur_2()
    {
        if (GameObject.Find("Player_1") == true)
        {
            Destroy(GameObject.Find("Player_1"));
        }
        Figure_nummer[1]++;
        if (Figure_nummer[1] > 11)
        {
            Figure_nummer[1] = 0;
        }
        Instantiate(Figur[Figure_nummer[1]], Player_Spawn_Position_Lobby[1].position, Quaternion.identity);

        if (GameObject.Find(Figur_Namen[Figure_nummer[1]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[1]]).name = "Player_1";
        }
    }
    public void Last_Spawn_Figur_2()
    {
        if (GameObject.Find("Player_1") == true)
        {
            Destroy(GameObject.Find("Player_1"));
        }
        Figure_nummer[1]--;
        if (Figure_nummer[1] < 0)
        {
            Figure_nummer[1] = 11;
        }
        Instantiate(Figur[Figure_nummer[1]], Player_Spawn_Position_Lobby[1].position, Quaternion.identity);
        if (GameObject.Find(Figur_Namen[Figure_nummer[1]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[1]]).name = "Player_1";
        }
    }
    public void Player_2_DropDown(int Selec)
    {
        GameManager.Player_2_Art = Selec;
        if (Selec == 1)
        {
            GameManager.Bot_Change = 1;
            GameManager.Player_2_Art = 1;
            Change_Bot();
        }
        else if (Selec == 0)
        {
            GameManager.Player_Change = 1;
            GameManager.Player_2_Art = 2;
            Change_Player();
        }
        else if (Selec == 2)
        {
            GameManager.Geschlossen_Change = 1;
            GameManager.Player_2_Art = 3;
            Change_Geschlossen();
        }
    }


    //Player 3
    public void Next_Spawn_Figur_3()
    {
        if (GameObject.Find("Player_2") == true)
        {
            Destroy(GameObject.Find("Player_2"));
        }
        Figure_nummer[2]++;
        if (Figure_nummer[2] > 11)
        {
            Figure_nummer[2] = 0;
        }
        Instantiate(Figur[Figure_nummer[2]], Player_Spawn_Position_Lobby[2].position, Quaternion.identity);

        if (GameObject.Find(Figur_Namen[Figure_nummer[2]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[2]]).name = "Player_2";
        }
    }
    public void Last_Spawn_Figur_3()
    {
        if (GameObject.Find("Player_2") == true)
        {
            Destroy(GameObject.Find("Player_2"));
        }
        Figure_nummer[2]--;
        if (Figure_nummer[2] < 0)
        {
            Figure_nummer[2] = 11;
        }
        Instantiate(Figur[Figure_nummer[2]], Player_Spawn_Position_Lobby[2].position, Quaternion.identity);
        if (GameObject.Find(Figur_Namen[Figure_nummer[2]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[2]]).name = "Player_2";
        }
    }
    public void Player_3_DropDown(int Selec)
    {
        GameManager.Player_3_Art = Selec;
        if (Selec == 1)
        {
            GameManager.Bot_Change = 2;
            GameManager.Player_3_Art = 1;
            Change_Bot();
        }
        else if (Selec == 0)
        {
            GameManager.Player_Change = 2;
            GameManager.Player_3_Art = 2;
            Change_Player();
        }
        else if (Selec == 2)
        {
            GameManager.Geschlossen_Change = 2;
            GameManager.Player_3_Art = 3;
            Change_Geschlossen();
        }
    }


    //Player 4
    public void Next_Spawn_Figur_4()
    {
        if (GameObject.Find("Player_3") == true)
        {
            Destroy(GameObject.Find("Player_3"));
        }
        Figure_nummer[3]++;
        if (Figure_nummer[3] > 11)
        {
            Figure_nummer[3] = 0;
        }
        Instantiate(Figur[Figure_nummer[3]], Player_Spawn_Position_Lobby[3].position, Quaternion.identity);

        if (GameObject.Find(Figur_Namen[Figure_nummer[3]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[3]]).name = "Player_3";
        }
    }

    public void Last_Spawn_Figur_4()
    {
        if (GameObject.Find("Player_3") == true)
        {
            Destroy(GameObject.Find("Player_3"));
        }
        Figure_nummer[3]--;
        if (Figure_nummer[3] < 0)
        {
            Figure_nummer[3] = 11;
        }
        Instantiate(Figur[Figure_nummer[3]], Player_Spawn_Position_Lobby[3].position, Quaternion.identity);
        if (GameObject.Find(Figur_Namen[Figure_nummer[3]]) == true)
        {
            GameObject.Find(Figur_Namen[Figure_nummer[3]]).name = "Player_3";
        }
    }
    public void Player_4_DropDown(int Selec)
    {
        GameManager.Player_4_Art = Selec;
        if (Selec == 1)
        {
            GameManager.Bot_Change = 3;
            GameManager.Player_4_Art = 1;
            Change_Bot();
        }
        else if (Selec == 0)
        {
            GameManager.Player_Change = 3;
            GameManager.Player_4_Art = 2;
            Change_Player();
        }
        else if (Selec == 2)
        {
            GameManager.Geschlossen_Change = 3;
            GameManager.Player_4_Art = 3;
            Change_Geschlossen();
        }
    }

    public void Load_SpielBrett()
    {
        GameManager.Player_1_Figurnummer = Figure_nummer[0];
        GameManager.Player_2_Figurnummer = Figure_nummer[1];
        GameManager.Player_3_Figurnummer = Figure_nummer[2];
        GameManager.Player_4_Figurnummer = Figure_nummer[3];
        SceneManager.LoadScene(2);
    }
    public void Load_Player_1()
    {
        Aktivat_Deaktivate[0] = Player_1_Lobby_Objects[0];
        Aktivat_Deaktivate[1] = Player_1_Lobby_Objects[1];
        Aktivat_Deaktivate[2] = Player_1_Lobby_Objects[2];
        Aktivat_Deaktivate[3] = Player_1_Lobby_Objects[3];
        Aktivat_Deaktivate[4] = Player_2_Lobby_Objects[4];
    }
    public void Load_Player_2()
    {
        Aktivat_Deaktivate[0] = Player_2_Lobby_Objects[0];
        Aktivat_Deaktivate[1] = Player_2_Lobby_Objects[1];
        Aktivat_Deaktivate[2] = Player_2_Lobby_Objects[2];
        Aktivat_Deaktivate[3] = Player_2_Lobby_Objects[3];
        Aktivat_Deaktivate[4] = Player_2_Lobby_Objects[4];
    }
    public void Load_Player_3()
    {
        Aktivat_Deaktivate[0] = Player_3_Lobby_Objects[0];
        Aktivat_Deaktivate[1] = Player_3_Lobby_Objects[1];
        Aktivat_Deaktivate[2] = Player_3_Lobby_Objects[2];
        Aktivat_Deaktivate[3] = Player_3_Lobby_Objects[3];
        Aktivat_Deaktivate[4] = Player_3_Lobby_Objects[4];
    }
    public void Load_Player_4()
    {
        Aktivat_Deaktivate[0] = Player_4_Lobby_Objects[0];
        Aktivat_Deaktivate[1] = Player_4_Lobby_Objects[1];
        Aktivat_Deaktivate[2] = Player_4_Lobby_Objects[2];
        Aktivat_Deaktivate[3] = Player_4_Lobby_Objects[3];
        Aktivat_Deaktivate[4] = Player_4_Lobby_Objects[4];
    }
}
