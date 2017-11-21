using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YellowButtonImage : MonoBehaviour
{

    public Text redButtonText;
    private GameObject testJsonData;
    private TestFileList myTestFileList;

    public string Url = @"http://atm.s3.amazonaws.com/Unity/red_sphere.png";

    void Start()
    {
        testJsonData = GameObject.Find("JsonData(Clone)");

        myTestFileList = testJsonData.GetComponent<TestFileList>();

        StartCoroutine("LoadImage");

        redButtonText.text = myTestFileList.buttons[3].title;

    }



    void Update()
    {

    }

    IEnumerator LoadImage()
    {
        WWW www = new WWW(Url);
        yield return www;

        Texture2D texture = www.texture;
        //this.gameObject.GetComponent<>().material.SetTexture( 0,texture );
        Image img = this.gameObject.GetComponent<Image>();
        img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

    }
}
