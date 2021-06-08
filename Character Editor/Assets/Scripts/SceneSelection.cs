using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelection : MonoBehaviour
{
    //warning back to main menu
    public GameObject Warning;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void LoadFemaleScene()
    {
        SceneManager.LoadScene("Female");
    }

    public void LoadMaleScene()
    {
        SceneManager.LoadScene("Male");
    }

    public void OnClickBacktoMainMenu()
    {
        Warning.gameObject.SetActive(true);
    }

    public void OnClickCancel()
    {
        Warning.gameObject.SetActive(false);
    }

    public void OnClickConfirmBacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
