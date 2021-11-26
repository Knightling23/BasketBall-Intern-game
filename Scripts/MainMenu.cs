using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    /*
    public Button startButton;
    public Button optionsButton;
    public Button exitButton;
    */
    void Start()
    {
       /* startButton.onClick.AddListener(StartButton);
        optionsButton.onClick.AddListener(OptionsButton);
        exitButton.onClick.AddListener(ExitButton);
        */

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void LevelButton()
    {


        SceneManager.LoadScene(3);

    }

    public void StartButton()
    {
       

        SceneManager.LoadScene(2);
        
    }

   public void OptionsButton()
    {
        SceneManager.LoadScene(1);
    }

   public void ExitButton()
    {
        Application.Quit();
    }
}
