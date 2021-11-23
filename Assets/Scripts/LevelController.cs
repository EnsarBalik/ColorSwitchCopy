using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private int nextSceneToLoad;
    public void Controller(int gelenbtn)
    {
        if (gelenbtn == 1)
        {
            nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneToLoad);
        }
        if (gelenbtn == 2)
        {

        }
        if (gelenbtn == 3)
        {

        }
    }
}
