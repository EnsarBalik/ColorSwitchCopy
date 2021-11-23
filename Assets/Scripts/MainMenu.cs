using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelGo(int gelenbtn)
    {
        if (gelenbtn == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (gelenbtn == 2)
        {
            Application.Quit();
            Debug.Log("Application Quit");
        }
    }
}
