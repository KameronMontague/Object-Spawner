using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestPanelInfo : MonoBehaviour {

    public Text testPanelText;
    private GameObject testJsonData;
    private TestFileList myTestFileList;


    void Start()
    {
        testJsonData = GameObject.Find("JsonData(Clone)");

        myTestFileList = testJsonData.GetComponent<TestFileList>();

        testPanelText.text = myTestFileList.title;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
