using UnityEngine;

public class Hypoteken : MonoBehaviour
{
    public int[] Best_Möglich = new int[40];
    public int Aktuell_Trai = 0;
    public int New_stand = 0;
    public int Best_Mögliche = 0;
    public int Best_Mögliche_Berag = 0;
    public int Max_Mögliche = 0;
    public int[] Full_Straßen = new int[10];
    public int s = 0;

    public void Hypotek_Aufnehmenn()
    {
        // is the Current Person a Player or a Bot
        if (GameManager.Player_Arten[GameManager.Next] == 1)
        {
            //Reset this Varabels
            Max_Mögliche = 0;
            New_stand = 0;
            Aktuell_Trai = 0;
            Best_Mögliche = 0;
            s = 0;
            Best_Mögliche_Berag = 9999999;
            for (int i = 0; i <= 9; i++)
            {
                Full_Straßen[i] = 0;
                Best_Möglich[i] = 0;
            }

            // Starts a Loop
            for (int i = 0; i <= 39; i++)
            {
                //Checked watt for Streets the Current Player have
                if (i == 2 || i == 4 || i == 7 || i == 10 || i == 17 || i == 20 || i == 22 || i == 30 || i == 33 || i == 36 || i == 38)
                {
                    // is this Correct do Naving
                }
                else if (GameManager.Freie_Straßen[i] == GameManager.Next && GameManager.Haus_Stufe[i] == 0)
                {
                    // is this Correct Increase the Max_Mögliche + 1 and Increase a Full_Street Value
                    Max_Mögliche += 1;
                    switch (i) 
                    {
                        case 1: case 3:
                            Full_Straßen[0] += 30;
                            break;
                        case 5: case 15: case 25: case 35:
                            Full_Straßen[1] += 100;
                            break;
                        case 6: case 8:
                            Full_Straßen[2] += 50;
                            break;
                        case 9:
                            Full_Straßen[2] += 60;
                            break;
                        case 11: case 13:
                            Full_Straßen[3] += 70;
                            break;
                        case 14:
                            Full_Straßen[3] += 80;
                            break;
                        case 16: case 18:
                            Full_Straßen[4] += 90;
                            break;
                        case 19:
                            Full_Straßen[4] += 100;
                            break;
                        case 21: case 23:
                            Full_Straßen[5] += 110;
                        break;
                        case 24:
                            Full_Straßen[5] += 120;
                            break;
                        case 26: case 27:
                            Full_Straßen[6] += 130;
                            break;
                        case 29:
                            Full_Straßen[6] += 140;
                            break;
                        case 28: case 12:
                            Full_Straßen[7] += 75;
                            break;
                        case 31: case 32:
                            Full_Straßen[8] += 150;
                            break;
                        case 34:
                            Full_Straßen[8] += 160;
                            break;
                        case 37:
                            Full_Straßen[9] += 175;
                            break;
                        case 39:
                            Full_Straßen[9] += 200;
                            break;
                    }
                }
            }
            if (Max_Mögliche > 0)
            {
                //is this Correct Create Variable a with a 41 Array Long and set the Frist Array Number to -1
                int[] a = new int[41];
                a[0] = -1;
                while (a[10] < 1)
                {
                    //Starts a Loop and Reset the Current Trail for Averie Loop and Increase A Array number um 0
                    Aktuell_Trai = 0;
                    a[0] += 1;
                    switch (a[0])
                    {
                        case 1:
                            // is the First array Number 1 Starts a loop and Increase Aktuell_Trai Value with Full_Straßen Value 
                            // but is a and Loop Number j the Value 1 have
                            for (int j = 0; j < 10; j++)
                            {
                                switch (a[j])
                                {
                                    case 1:
                                        Aktuell_Trai += Full_Straßen[j];
                                        break;
                                }
                            }
                            break;
                        case 2:
                            // is the First array Number 2 Starts a loop and Set Every a Value j Number 2 to 0 and s 1 Increase
                            // and Increase Aktuell_Trai Value with Full_Straßen Value 
                            // but is a and Loop Number j the Value 1 have
                            for (int j = 0; j < 10; j++)
                            {
                                s = j + 1;
                                switch (a[j])
                                {
                                    case 2:
                                        a[j] = 0;
                                        a[s] += 1;
                                        break;
                                }
                                switch (a[j])
                                {
                                    case 1:
                                        Aktuell_Trai += Full_Straßen[j];
                                        break;
                                }
                            }
                            break;
                    }
                    //Added the Current player Money with the Aktuell_Trai
                    New_stand = Aktuell_Trai + GameManager.Player_Money[GameManager.Next];

                    // Checked New_Stand Lower as Best_Mögliche_Berag and New_stand Higher as 0
                    if (Best_Mögliche_Berag > New_stand && New_stand > 0)
                    {
                        // is this Correct Chanche the Best Value
                        Best_Mögliche_Berag = New_stand;
                        // and Save the Series
                        for (int o = 0; o < 10; o++)
                        {
                                            Best_Möglich[o] = a[o];
                        }
                    }
                }
                //Starts a Loop and Chack Every Street is the Current Player Own and is this the Best Series Number
                //is this Correct add the Current player Money
                for (int i = 0; i <= 10; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (GameManager.Freie_Straßen[1] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[1] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 1];
                            }
                            if (GameManager.Freie_Straßen[3] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[3] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 3];
                            }
                            break;
                        case 1:
                            if (GameManager.Freie_Straßen[5] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[5] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 5];
                            }
                            if (GameManager.Freie_Straßen[15] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[15] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 15];
                            }
                            if (GameManager.Freie_Straßen[25] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[25] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 25];
                            }
                            if (GameManager.Freie_Straßen[35] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[35] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 35];
                            }
                            break;
                        case 2:
                            if (GameManager.Freie_Straßen[6] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[6] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 6];
                            }
                            if (GameManager.Freie_Straßen[8] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[8] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 8];
                            }
                            if (GameManager.Freie_Straßen[9] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[9] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 9];
                            }
                            break;
                        case 3:
                            if (GameManager.Freie_Straßen[11] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[11] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 11];
                            }
                            if (GameManager.Freie_Straßen[13] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[13] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 13];
                            }
                            if (GameManager.Freie_Straßen[14] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[14] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 14];
                            }
                            break;
                        case 4:
                            if (GameManager.Freie_Straßen[16] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[16] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 16];
                            }
                            if (GameManager.Freie_Straßen[18] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[18] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 18];
                            }
                            if (GameManager.Freie_Straßen[19] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[19] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 19];
                            }
                            break;
                        case 5:
                            if (GameManager.Freie_Straßen[21] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[21] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 21];
                            }
                            if (GameManager.Freie_Straßen[23] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[23] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 23];
                            }
                            if (GameManager.Freie_Straßen[24] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[24] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 24];
                            }
                            break;
                        case 6:
                            if (GameManager.Freie_Straßen[26] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[26] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 26];
                            }
                            if (GameManager.Freie_Straßen[27] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[27] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 27];
                            }
                            if (GameManager.Freie_Straßen[29] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[29] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 29];
                            }
                            break;
                        case 7:
                            if (GameManager.Freie_Straßen[28] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[28] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 28];
                            }
                            if (GameManager.Freie_Straßen[12] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[12] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 12];
                            }
                            break;
                        case 8:
                            if (GameManager.Freie_Straßen[31] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[31] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 31];
                            }
                            if (GameManager.Freie_Straßen[32] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[32] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 32];
                            }
                            if (GameManager.Freie_Straßen[34] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[34] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 34];
                            }
                            break;
                        case 9:
                            if (GameManager.Freie_Straßen[37] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[37] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 37];
                            }
                            if (GameManager.Freie_Straßen[39] == GameManager.Next && Best_Möglich[i] == 1)
                            {
                                GameManager.Offene_Hypoteken[39] = 1;
                                GameManager.Player_Money[GameManager.Next] += GameManager.Straßen_Hypoteken[0, 39];
                            }
                            break;
                    }
                }
                //Called a GameObject with the Script and the Funktion 
                GameObject.Find("Main_Game").GetComponent<Main_Gamepart>().Change_Money_Screen();
            }
        }
    }
}