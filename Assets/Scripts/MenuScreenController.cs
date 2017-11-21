using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour {


    public void StartTest()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void ReturnToMenu()
    {

        SceneManager.LoadScene(sceneName: "MenuScreen");

    }

}
