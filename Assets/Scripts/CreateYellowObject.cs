using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateYellowObject : PoolObject {

    public GameObject yellowCube;
    private TestController testController;
    public Transform boxTransform;
    private int pooledAmount = 20;


    // Use this for initialization
    void Start()
    {
        testController = FindObjectOfType<TestController>();
        PoolManager.instance.CreatePool(yellowCube, pooledAmount);

    }

    public void YellowFire()
    {
        testController.YellowButtonClicked();
        testController.ObjectButtonClicked();

        PoolManager.instance.ReuseObject(yellowCube, boxTransform.position, boxTransform.rotation);
    }

    public override void OnObjectReuse()
    {
        transform.localScale = Vector3.one;
    }
}
