using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using LitJson;
using System.IO;

public class TestController : CollisionDetectedAmount {

    //Object Text Info
    public Text testPanelTitle;
    public Text objectAmountText;
    public Text redButtonText;
    public Text greenButtonText;
    public Text blueButtonText;
    public Text yellowButtonText;
    public Text orangeButtonText;
    public Text purpleButtonText;
    public Text redObjectText;
    public Text greenObjectText;
    public Text blueObjectText;
    public Text yellowObjectText;
    public Text orangeObjectText;
    public Text purpleObjectText;

    //Panel Controller
    //public GameObject testPanel;
    //public GameObject testSummary;
    //private bool isTestActive;

    private DataController dataController;

    //Tracking Collision Data
    public ObjectTracker objectAmountData;

    //public Text redCollisionDisplay;
    public CollisionDetectedAmount redCollisionNumberData;
    public CollisionDetectedAmount greenCollisionNumberData;
    public CollisionDetectedAmount blueCollisionNumberData;
    public CollisionDetectedAmount yellowCollisionNumberData;
    public CollisionDetectedAmount orangeCollisionNumberData;
    public CollisionDetectedAmount purpleCollisionNumberData;

    private TestFileList[] testGroupPool;

    private TitleText titleText;
    private MaxObjectsText maxObjectsText;

    private bool areButtonsLeft;

    private bool objectAdded;
    private bool redAdded;
    private bool greenAdded;
    private bool blueAdded;
    private bool yellowAdded;
    private bool orangeAdded;
    private bool purpleAdded;

    private int maxObjects;
    private int buttonGroupIndex;

    public GameObject redButtonCreateObject;
    public GameObject greenButtonCreateObject;
    public GameObject blueButtonCreateObject;
    public GameObject yellowButtonCreateObject;
    public GameObject orangeButtonCreateObject;
    public GameObject purpleButtonCreateObject;

    //private List<GameObject> createdButtonGameObjects = new List<GameObject>();

    //private List<GameObject> maxGameObjects = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        counted = 0;
		
	}


    /*public void EndTheTest()
    {
        isTestActive = false;

        testPanel.SetActive(false);
        testSummary.SetActive(true);
    }*/

    public void ObjectButtonClicked()
    {
        objectAdded = true;
        //redAdded = true;
    }

    public void RedButtonClicked()
    {
        redAdded = true;
    }

    public void GreenButtonClicked()
    {
        greenAdded = true;
    }

    public void BlueButtonClicked()
    {
        blueAdded = true;
    }

    public void YellowButtonClicked()
    {
        yellowAdded = true;
    }

    public void OrangeButtonClicked()
    {
        orangeAdded = true;
    }

    public void PurpleButtonClicked()
    {
        purpleAdded = true;
    }

    
    private void RedObjectsLimitAmount()
    {

        if (objectAmountData.redNumberIncreased > 19)
        {
            objectAmountData.redNumberIncreased -= 1;
            objectAmountData.redNumberIncreased = 20;
        }
    }
    private void GreenObjectsLimitAmount()
    {

        if (objectAmountData.greenNumberIncreased > 19)
        {
            objectAmountData.greenNumberIncreased -= 1;
            objectAmountData.greenNumberIncreased = 20;
        }
    }
    private void BlueObjectsLimitAmount()
    {

        if (objectAmountData.blueNumberIncreased > 19)
        {
            objectAmountData.blueNumberIncreased -= 1;
            objectAmountData.blueNumberIncreased = 20;
        }
    }
    private void YellowObjectsLimitAmount()
    {

        if (objectAmountData.yellowNumberIncreased > 19)
        {
            objectAmountData.yellowNumberIncreased -= 1;
            objectAmountData.yellowNumberIncreased = 20;
        }
    }
    private void OrangeObjectsLimitAmount()
    {
         

        if (objectAmountData.orangeNumberIncreased > 19)
        {
            objectAmountData.orangeNumberIncreased -= 1;
            objectAmountData.orangeNumberIncreased = 20;
        }
    }
    private void PurpleObjectsLimitAmount()
    {

        if (objectAmountData.purpleNumberIncreased > 19)
        {
            objectAmountData.purpleNumberIncreased -= 1;
            objectAmountData.purpleNumberIncreased = 20;
        }
    }
   
    #region Check Amount of Each Object
    private void CheckRedAmount()
    {
        if (redAdded)
        {

            objectAmountData.redNumberIncreased += 1;
        }
    }

    private void CheckGreenAmount()
    {
        if (greenAdded)
        {

            objectAmountData.greenNumberIncreased += 1;
        }
    }

    private void CheckBlueAmount()
    {
        if (blueAdded)
        {

            objectAmountData.blueNumberIncreased += 1;
        }
    }

    private void CheckYellowAmount()
    {
        if (yellowAdded)
        {

            objectAmountData.yellowNumberIncreased += 1;
        }
    }

    private void CheckOrangeAmount()
    {
        if (orangeAdded)
        {

            objectAmountData.orangeNumberIncreased += 1;
        }
    }

    private void CheckPurpleAmount()
    {
        if (purpleAdded)
        {

            objectAmountData.purpleNumberIncreased += 1;
        }
    }
    #endregion


    void Update () {

        
        if (objectAdded)
        {
            //ObjectsLimitAmount();
            //objectAmountData.objectNumberIncreased += 1;
            //redCollisionNumberData.collisionCounter += 1;
            //greenCollisionNumberData.collisionCounter += 1;
            

            CheckRedAmount();
            CheckGreenAmount();
            CheckBlueAmount();
            CheckYellowAmount();
            CheckOrangeAmount();
            CheckPurpleAmount();

            RedObjectsLimitAmount();
            GreenObjectsLimitAmount();
            BlueObjectsLimitAmount();
            YellowObjectsLimitAmount();
            OrangeObjectsLimitAmount();
            PurpleObjectsLimitAmount();

            objectAdded = false;
            redAdded = false;
            greenAdded = false;
            blueAdded = false;
            yellowAdded = false;
            orangeAdded = false;
            purpleAdded = false;

            //Debug.Log(objectAmountData.objectNumberIncreased);
        }
        else
        {
            
            objectAmountText.text = "Total Collisions: " + counted;
            redObjectText.text = "Red : " + objectAmountData.redNumberIncreased + "/20";
            greenObjectText.text = "Green : " + objectAmountData.greenNumberIncreased + "/20";
            blueObjectText.text = "Blue : " + objectAmountData.blueNumberIncreased + "/20";
            yellowObjectText.text = "Yellow : " + objectAmountData.yellowNumberIncreased + "/20";
            orangeObjectText.text = "Orange : " + objectAmountData.orangeNumberIncreased + "/20";
            purpleObjectText.text = "Purple : " + objectAmountData.purpleNumberIncreased + "/20";
            objectAdded = false;
            redAdded = false;
            greenAdded = false;
            blueAdded = false;
            yellowAdded = false;
            orangeAdded = false;
            purpleAdded = false;

        }
        //Debug.Log(collisionCounter);

        /*
            foreach (GameObject thisObj in GameObject.FindGameObjectsWithTag("CollisionText"))
            {
                objectAmountText.text = "Total Collisions" + thisObj.GetComponent<Text>().text;
            }*/

    }

}

