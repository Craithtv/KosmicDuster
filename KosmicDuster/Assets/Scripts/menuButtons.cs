using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuButtons : MonoBehaviour
{
    public GameObject areYouSure;
    public GameObject settings;
    public GameObject instructions;

    public void StartButton () 
    {
        SceneManager.LoadScene("CraftedLevel");
    }

    public void SettingsButting ()
    {
        settings.SetActive(true);
    }

    public void QuitButton()
    {
        areYouSure.SetActive(true);
        //Application.Quit();
    }

    public void InstructionPanel()
    {
        instructions.SetActive(true);
    }

    public void CloseButton()
    {
        settings.SetActive(false);
        areYouSure.SetActive(false);
        instructions.SetActive(false);
    }
}
