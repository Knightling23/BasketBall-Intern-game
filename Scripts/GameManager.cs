using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject StartMenuUI;
    public GameObject SettingsUI;

    public GameObject pauseMenuUI;
    public GameObject pauseButtonUI;
    public GameObject correctButtonUI;
    public GameObject wrong;


    // Start is called before the first frame update
    void Start()
    {
        StartMenuUI.SetActive(true);
        SettingsUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        pauseButtonUI.SetActive(true);
        correctButtonUI.SetActive(false);
    }

    public void GoToStart()
    {
        SceneManager.LoadScene(0);
        StartMenuUI.SetActive(true);
        SettingsUI.SetActive(false);
    }

    public void GoToSettings()
    {
        StartMenuUI.SetActive(false);
        SettingsUI.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GoToLevels()
    {
        SceneManager.LoadScene(1);
        StartMenuUI.SetActive(true);
        SettingsUI.SetActive(false);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseButtonUI.SetActive(false);
    }

    public void UnPause()
    {
        pauseMenuUI.SetActive(false);
        pauseButtonUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Correct()
    {
        correctButtonUI.SetActive(true);
    }

    public void CorrectOff()
    {
        correctButtonUI.SetActive(false);
    }
}
