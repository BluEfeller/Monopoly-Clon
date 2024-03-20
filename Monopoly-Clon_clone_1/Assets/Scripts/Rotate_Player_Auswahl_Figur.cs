using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Player_Auswahl_Figur : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);        
    }
}
