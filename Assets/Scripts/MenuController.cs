using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuController : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("mainScene"); // Load Game scene
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit Pressed!!!!");
    }
}
