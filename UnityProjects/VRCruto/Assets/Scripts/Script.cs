using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Script : MonoBehaviour
{
    public Text text_name;
    public Text text_city;
    public InputField string_name;
    public RawImage animal;
    public Text text_privet;
    public Text test;
    public Text chuknoris;
    [SerializeField]
    Image _loadingbar;
    public GameObject loadbar;

    void Awake()
    {
        StartCoroutine(GetText("http://10.0.118.3:5000/", ""));;   
    }
    public void GetCity() 
    {
        StartCoroutine(GetText("http://10.0.118.3:5000/city", "city"));
    }
    public void GetName()
    {
        StartCoroutine(GetText("http://10.0.118.3:5000/name?name=", "name"));;
    }
    public void GetAnimal()
    {
        StartCoroutine(GetText("http://10.0.118.3:5000/animals", "animal"));
    }
    public void GetChuknoris()
    {
        chuknoris.text = "";
        loadbar.SetActive(true);
        StartCoroutine(GetText("http://10.0.118.16:5000/api/chucknorris", "chuknoris"));
    }

    IEnumerator GetText(string uri, string choose) {
        UnityWebRequest www = UnityWebRequest.Get(uri);
        DownloadHandler handler = www.downloadHandler;
        //www.downloadHandler = new DownloadHandlerBuffer();
        www.SendWebRequest();
        while(!www.isDone)
        {
            Debug.Log(www.downloadProgress);
            _loadingbar.fillAmount =+ 0.2f;
            yield return null;
        }

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }

        else 
        {   
            if(choose == "") { text_privet.text = www.downloadHandler.text; }   
            if(choose == "name") { text_name.text = www.downloadHandler.text + string_name.text; }   
            if(choose == "city") { text_city.text = www.downloadHandler.text; }
            if(choose == "chuknoris") { chuknoris.text = www.downloadHandler.text; loadbar.SetActive(false); }
            if(choose == "animal"){Match match = Regex.Match(www.downloadHandler.text, @"\""url\""\s*:\s*\""(.*?)\"""); StartCoroutine(GetImage(match.Groups[1].Value));};   
        }
    }
    
    IEnumerator GetImage(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {animal.texture = DownloadHandlerTexture.GetContent(www);}


    }
}