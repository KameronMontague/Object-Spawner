using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePurpleObject : PoolObject {

    public GameObject purpleCube;
    private TestController testController;
    public Transform boxTransform;
    private int pooledAmount = 20;


    // Use this for initialization
    void Start()
    {
        testController = FindObjectOfType<TestController>();
        PoolManager.instance.CreatePool(purpleCube, pooledAmount);

    }

    public void PurpleFire()
    {
        testController.PurpleButtonClicked();
        testController.ObjectButtonClicked();

        PoolManager.instance.ReuseObject(purpleCube, boxTransform.position, boxTransform.rotation);
    }

    public override void OnObjectReuse()
    {
        transform.localScale = Vector3.one;
    }
}
