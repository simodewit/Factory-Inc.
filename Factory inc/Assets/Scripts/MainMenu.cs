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
    //public GameObject manager;

    public void Start()
    {
        //manager = GameObject.Find("MainMusicManager");
    }

    public void OnClickPlay()
    {
        //manager.GetComponent<MusicManager>().SoundEffect();
        print("Play");
    }

    public void OnClickBackSettings()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
        //manager.GetComponent<MusicManager>().SoundEffect();
    }

    public void OnClickSettings()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
        //manager.GetComponent<MusicManager>().SoundEffect();
    }

    public void OnClickBackCredits()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
        //manager.GetComponent<MusicManager>().SoundEffect();
    }

    public void OnClickCredits()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
        //manager.GetComponent<MusicManager>().SoundEffect();
    }

    public void OnClickNoExitGame()
    {
        mainMenu.SetActive(true);
        exitgame.SetActive(false);
        //manager.GetComponent<MusicManager>().SoundEffect();
    }

    public void OnClickExitGame()
    {
        mainMenu.SetActive(false);
        exitgame.SetActive(true);
        //manager.GetComponent<MusicManager>().SoundEffect();
    }

    public void OnClickYesExitGame()
    {
        //manager.GetComponent<MusicManager>().SoundEffect();
        Application.Quit();
    }
}
