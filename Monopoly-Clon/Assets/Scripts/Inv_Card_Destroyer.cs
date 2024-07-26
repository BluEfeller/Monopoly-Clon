using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inv_Card_Destroyer : MonoBehaviour
{
    [SerializeField]
    private int Destroy_by_Sceen = 10;
    private int Time = 0;
    private int interval = 4;
    // Update is called once per frame
    void Update()
    {
        Time += 1;
        if (Time%interval == 0)
        {
            if(GameManager.Current_Sceen > Destroy_by_Sceen || GameManager.Current_Sceen < Destroy_by_Sceen)
            {
                Destroy(gameObject);
            }
        }
    }
}
