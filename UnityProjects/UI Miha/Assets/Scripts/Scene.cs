using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Sett()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void CloseProg()
    {
        Application.Quit();
    }
    public void LvL()
    {
        SceneManager.LoadScene(1);
    }
}
