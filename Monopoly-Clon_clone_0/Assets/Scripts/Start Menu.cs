using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public GameObject Start_Menu;
    public GameObject Options;



    // Start is called before the first frame update
    void Start()
    {
        Start_Menu.SetActive(true);
        Options.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Chanche_to_Options()
    {
        Start_Menu.SetActive(false);
        Options.SetActive(true);
    }

    public void Chanche_to_Hauptmenu()
    {
        Start_Menu.SetActive(true);
        Options.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Chanche_to_Singelplayer()
    {
        SceneManager.LoadScene(1);
    }

    public void Chanche_to_Multiplayer()
    {
        SceneManager.LoadScene(2);
    }
}
