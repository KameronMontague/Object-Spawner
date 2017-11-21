using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTest : MonoBehaviour {

    public GameObject testPanel;
    public GameObject testSummary;
    public GameObject testController;
    private bool isTestActive;


    public void EndTheTest()
    {
        isTestActive = false;

        testPanel.SetActive(false);
        testSummary.SetActive(true);
        testController.SetActive(false);

    }
}
