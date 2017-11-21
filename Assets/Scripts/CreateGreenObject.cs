using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGreenObject : PoolObject {


    public GameObject greenCube;
    private TestController testController;
    public Transform boxTransform;
    private int pooledAmount = 20;


    // Use this for initialization
    void Start()
    {
        testController = FindObjectOfType<TestController>();
        PoolManager.instance.CreatePool(greenCube, pooledAmount);

    }

    public void GreenFire()
    {
        testController.GreenButtonClicked();
        testController.ObjectButtonClicked();

        PoolManager.instance.ReuseObject(greenCube, boxTransform.position, boxTransform.rotation);
    }

    public override void OnObjectReuse()
    {
        transform.localScale = Vector3.one;
    }



}