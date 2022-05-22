using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTotal : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void GameExit()       
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

    public void Restart() 
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }





}
