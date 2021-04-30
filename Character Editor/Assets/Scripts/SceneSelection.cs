using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
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

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
