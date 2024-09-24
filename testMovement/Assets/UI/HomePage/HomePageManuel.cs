using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePageManuel : MonoBehaviour
{
   public void StartButton()
    {
        SceneManager.LoadScene("LevelManuel");
    }
    public void OptionButton()
    {
        SceneManager.LoadScene("OptionManuel");
    }
    public void QuitGameButton()
    {
        Application.Quit();
    }
}
