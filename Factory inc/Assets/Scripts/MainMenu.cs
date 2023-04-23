using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    public GameObject credits;
    public GameObject exitgame;
    public AudioSource soundEffect;

    public void OnClickPlay()
    {
        buttonPress();
        print("Play");
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
        mainMenu.SetActive(false);
        settings.SetActive(true);
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
        mainMenu.SetActive(false);
        credits.SetActive(true);
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
        mainMenu.SetActive(false);
        exitgame.SetActive(true);
    }

    public void OnClickYesExitGame()
    {
        buttonPress();
        Application.Quit();
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
