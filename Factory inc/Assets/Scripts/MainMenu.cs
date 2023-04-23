using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject mainMenu;
    public GameObject settings;
    public GameObject credits;
    public GameObject exitgame;
    public GameObject playerAmount;
    public GameObject createLobby;
    public AudioSource soundEffect;
    private bool check;

    public void Update()
    {
        if (check == false)
        {
            if (Input.anyKey)
            {
                //make loading screen and multiplayer connection
                check = true;
                buttonPress();
                mainMenu.SetActive(true);
                startScreen.SetActive(false);
            }
        }
    }

    public void OnClickPlay()
    {
        buttonPress();
        playerAmount.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OnClickBackSettings()
    {
        buttonPress();
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }

    public void OnClickSettings()
    {
        buttonPress();
        settings.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OnClickBackCredits()
    {
        buttonPress();
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }

    public void OnClickCredits()
    {
        buttonPress();
        credits.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OnClickNoExitGame()
    {
        buttonPress();
        mainMenu.SetActive(true);
        exitgame.SetActive(false);
    }

    public void OnClickExitGame()
    {
        buttonPress();
        exitgame.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OnClickYesExitGame()
    {
        buttonPress();
        Application.Quit();
    }

    public void OnClickBackPlayerAmount()
    {
        buttonPress();
        mainMenu.SetActive(true);
        playerAmount.SetActive(false);
    }

    public void OnClickSinglePlayer()
    {
        buttonPress();
        //join Game
    }

    public void OnClickMultiplayer()
    {
        buttonPress();
        createLobby.SetActive(true);
        playerAmount.SetActive(false);
    }

    public void OnClickBackCreateLobby()
    {
        buttonPress();
        playerAmount.SetActive(true);
        createLobby.SetActive(false);
    }

    public void OnClickCreate()
    {
        buttonPress();
        //create Game
    }

    public void OnClickJoin()
    {
        buttonPress();
        //join Game
    }

    public void buttonPress()
    {
        if(soundEffect.enabled == false)
        {
            soundEffect.enabled = true;
        }
        else
        {
            soundEffect.Play();
        }
    }
}
