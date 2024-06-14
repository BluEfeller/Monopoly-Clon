using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_Movement : MonoBehaviour
{
    public void Move_Players()
    {
        // is GameObject with the Name Existent?
        if (GameObject.Find(GameManager.Player_Figure_Namen[GameManager.Next]) == true)
        {
            //Search GameObject for Player 1 and Chanched the Player Model to a other position
            GameObject.Find(GameManager.Player_Figure_Namen[GameManager.Next]).transform.position = new Vector3(GameManager.Player_Positioenen_insgesamt[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].position.x, GameManager.Player_Positioenen_insgesamt[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].position.y, GameManager.Player_Positioenen_insgesamt[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].position.z);
        }
        // is GameObject not Existent use the Dev GameObject for move
        else if (GameObject.Find(GameManager.Player_Figure_Namen[GameManager.Next] + 4) == true)
        {
            // Same in the uper if but Dev Model
            Debug.Log("Dev Bild");
            GameObject.Find(GameManager.Player_Figure_Namen[GameManager.Next + 4]).transform.position = new Vector3(GameManager.Player_Positioenen_insgesamt[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].position.x, GameManager.Player_Positioenen_insgesamt[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].position.y, GameManager.Player_Positioenen_insgesamt[GameManager.Next, GameManager.Player_Positionen[GameManager.Next]].position.z);
        }
        GameObject.Find("Field_Check").GetComponent<Watt_for_Field>().Check_Player_Field(); // Calld the Funktion Check_Player_Field
    }

}
