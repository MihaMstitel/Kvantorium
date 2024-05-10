using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void PlayAll(string x)
    {
        SceneManager.LoadScene(x); //Ставим сцену на которую надо переключиться
    }
    public void ExitApp()
    {
        Application.Quit(); //Выход из игры
    }
    public void Back()
    {
        SceneManager.LoadScene("Main Menu"); //Вернуться в главное меню(по кнопке интерфейса)
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //void Update()
    //{
        //if(Input.GetKey(KeyCode.Escape)) //Вернуться в главное меню(по кнопке ESC)
        //{
            //SceneManager.LoadScene(0);
        //}
        //if(Input.GetKey(KeyCode.R)) //Рестарт уровня
        //{
          //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       // }
    //}
}
