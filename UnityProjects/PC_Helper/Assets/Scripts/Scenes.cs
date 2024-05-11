using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Cat()
    {
        SceneManager.LoadScene("Catalog");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Procc()
    {
        SceneManager.LoadScene("Proccesors");
    }
    public void Video()
    {
        SceneManager.LoadScene("VideoCards");
    }
    public void Ram()
    {
        SceneManager.LoadScene("Ram");
    }
    public void MotherBoard()
    {
        SceneManager.LoadScene("MotherBoards");
    }
    public void Energy()
    {
        SceneManager.LoadScene("EnergyBlocks");
    }
    public void Frame()
    {
        SceneManager.LoadScene("Frames");
    }
    public void Back()
    {
        SceneManager.LoadScene("Catalog");
    }
}
