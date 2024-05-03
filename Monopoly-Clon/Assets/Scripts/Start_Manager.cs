using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Figuren;

    [SerializeField]
    private string[] FigureName;

    [SerializeField]
    private Transform[] Figuren_Spawnpoint;

    [SerializeField]
    private string[] Bot_Namen;




    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Player_1_Art == 1 || GameManager.Player_1_Art == 2)
        {
            Instantiate(Figuren[GameManager.Player_1_Figurnummer], Figuren_Spawnpoint[0].position, Quaternion.identity);
            if (GameObject.Find(FigureName[GameManager.Player_1_Figurnummer]) == true)
            {
                GameObject.Find(FigureName[GameManager.Player_1_Figurnummer]).name = "Player_1";
                GameObject.Find("Player_1").transform.Rotate(0f, 270f, 0f);
            }
        }

        if (GameManager.Player_2_Art == 1 || GameManager.Player_2_Art == 2)
        {
            Instantiate(Figuren[GameManager.Player_2_Figurnummer], Figuren_Spawnpoint[1].position, Quaternion.identity);
            if (GameObject.Find(FigureName[GameManager.Player_2_Figurnummer]) == true)
            {
                GameObject.Find(FigureName[GameManager.Player_2_Figurnummer]).name = "Player_2";
                GameObject.Find("Player_2").transform.Rotate(0f, 270f, 0f);
            }
        }

        if (GameManager.Player_3_Art == 1 || GameManager.Player_3_Art == 2)
        {
            Instantiate(Figuren[GameManager.Player_3_Figurnummer], Figuren_Spawnpoint[2].position, Quaternion.identity);
            if (GameObject.Find(FigureName[GameManager.Player_3_Figurnummer]) == true)
            {
                GameObject.Find(FigureName[GameManager.Player_3_Figurnummer]).name = "Player_3";
                GameObject.Find("Player_3").transform.Rotate(0f, 270f, 0f);
            }
        }

        if (GameManager.Player_4_Art == 1 || GameManager.Player_4_Art == 2)
        {
            Instantiate(Figuren[GameManager.Player_4_Figurnummer], Figuren_Spawnpoint[3].position, Quaternion.identity);
            if (GameObject.Find(FigureName[GameManager.Player_4_Figurnummer]) == true)
            {
                GameObject.Find(FigureName[GameManager.Player_4_Figurnummer]).name = "Player_4";
                GameObject.Find("Player_4").transform.Rotate(0f, 270f, 0f);
            }
        }
    }
}
