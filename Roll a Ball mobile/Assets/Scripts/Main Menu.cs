using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void GmeExit()       
    {
        Application.Quit ();
    }
     public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void ChooseLevels(int x)
    {
        SceneManager.LoadScene(x);
    }
}
