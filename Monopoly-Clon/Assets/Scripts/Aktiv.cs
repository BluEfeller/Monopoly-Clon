using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aktiv : MonoBehaviour
{
    [SerializeField]
    private GameObject Spieler_Figurerrr;
    void Start()
    {
        Spieler_Figurerrr.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
