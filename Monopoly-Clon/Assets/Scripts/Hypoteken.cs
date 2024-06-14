using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hypoteken : MonoBehaviour
{
    public int[] Current_Player = new int[40];
    public int[] Best_Möglich = new int[40];
    public int Aktuell_Trai = 0;
    public int New_stand = 0;
    public int Best_Mögliche = 0;
    public int Best_Mögliche_Berag = 0;
    public int Max_Mögliche = 0;
    public void Hypotek_Aufnehmen()
    {
        if (GameManager.Player_Arten[GameManager.Next] == 1)
        {
            Max_Mögliche = 0;
            New_stand = 0;
            Aktuell_Trai = 0;
            Best_Mögliche = 0;
            Best_Mögliche_Berag = 0;
            for (int i = 0; i <= 39; i++)
            {
                Current_Player[i] = 0;
                Best_Möglich[i] = 0;
            }
            for (int i = 0; i <= 39; i++)
            {
                if (GameManager.Freie_Straßen[i] == GameManager.Next)
                {
                    Current_Player[i] = GameManager.Straßen_Hypoteken[1, i];
                    Max_Mögliche += 1;
                }
            }
            for (int i = 0; i <= 39; i++)
            {
                if (GameManager.Haus_Stufe[i] > 0)
                {
                    Max_Mögliche -= 1;
                    Current_Player[i] = 0;
                }
            }
            if (Max_Mögliche > 0)
            {
                int[] a = new int[40];
                a[0] = -1;
                for (int i = 0; i <= 40 * 40; i++)
                {
                    a[0] += 1;
                    for (int j = 0; j < 40; j++)
                    {
                        a[j] = a[j] % 2;
                    }
                    Aktuell_Trai = Current_Player[a[0]]+ Current_Player[a[1]] + Current_Player[a[2]] + Current_Player[a[3]] + Current_Player[a[4]] + Current_Player[a[5]] + Current_Player[a[6]] + Current_Player[a[7]] + Current_Player[a[8]] + Current_Player[a[9]] + Current_Player[a[10]] + Current_Player[a[11]] + Current_Player[a[12]] + Current_Player[a[13]] + Current_Player[a[14]] + Current_Player[a[15]] + Current_Player[a[16]] + Current_Player[a[17]] + Current_Player[a[18]] + Current_Player[a[19]] + Current_Player[a[20]] + Current_Player[a[21]] + Current_Player[a[22]] + Current_Player[a[23]] + Current_Player[a[24]] + Current_Player[a[25]] + Current_Player[a[26]] + Current_Player[a[27]];
                    New_stand = GameManager.Player_Money[GameManager.Next] + Aktuell_Trai;
                    if (New_stand <= 0 && Best_Mögliche_Berag > New_stand)
                    {
                        Best_Mögliche_Berag = New_stand;
                        for (int o = 0; o < 40; o++)
                        {
                            if (Current_Player[o] > 0 && a[o] == 1)
                            {
                                Best_Möglich[o] = a[o];
                            }
                            else
                            {
                                Best_Möglich[o] = 0;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i <= 39; i++)
            {

            }


        }
    }
}
