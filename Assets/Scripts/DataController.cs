using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using System.Net;
using UnityEngine.UI;
using Newtonsoft.Json;
using LitJson;

public class DataController : MonoBehaviour {

    private string url = "http://atm.s3.amazonaws.com/Unity/UnityTest.json";

    //private JsonData jsonvale;


    void Start()
    {

     CreateSomething();

     DontDestroyOnLoad(gameObject);

     SceneManager.LoadScene("MenuScreen");

    }

    public void CreateSomething()
    {
        TextAsset textAsset = (TextAsset)Resources.Load("data");
        string jsonString = textAsset.text;

        GameObject prefab = (GameObject)Resources.Load("JsonData");
        GameObject newObject = (GameObject)Instantiate(prefab);
        TestFileList newRedSphere = newObject.GetComponent<TestFileList>();

        JsonUtility.FromJsonOverwrite(jsonString, newRedSphere);
        DontDestroyOnLoad(newRedSphere);
    }
    /*
    IEnumerator GetJsonData()
    {
        if (url.Contains("://"))
        {
            WWW www = new WWW(url);
            yield return www;
            jsonString = www.text;
        }
        else
        {
            jsonString = File.ReadAllText(url);
        }

         if (www.error == null)
            {
                //Processjson(get.text);
            }
            else
            {
                Debug.Log("ERROR: " + get.error);
            }
        
    }*/

    /*
    //Loads some JSON Data
    private void Processjson(String jsonString)
     {
         jsonvale = JsonMapper.ToObject(jsonString);
        TestFileList parsejson;
         parsejson = new TestFileList();

         parsejson.title = jsonvale["title"].ToString();

         parsejson.maxObjects = jsonvale["maxObjects"].Count;

         parsejson.buttons = new ArrayList();

         //parsejson.but_image = new ArrayList();
         //parsejson.but_color = new ArrayList();
         //parsejson.but_type = new ArrayList();
         //parsejson.but_obey_gravity = new ArrayList();


         for (int i = 0; i < jsonvale["buttons"].Count; i++)
         {
             parsejson.buttons.Add(jsonvale["buttons"][i]["title"].ToString());
             //parsejson.but_image.Add(jsonvale["buttons"][i]["image"].ToString());
             //parsejson.but_image.Add(jsonvale["buttons"][i]["color"].ToString());// Orange Sphere has no Color
             //parsejson.but_image.Add(jsonvale["buttons"][i]["type"].ToString());
             //parsejson.but_image.Add(jsonvale["buttons"][i]["obeyGravity"].ToString());
             
         }
    }
    */

}


