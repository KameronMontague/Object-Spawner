using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBlueObject : PoolObject {

    public GameObject blueSphere;
    private TestController testController;
    public Transform boxTransform;
    private int pooledAmount = 20;


    // Use this for initialization
    void Start()
    {
        testController = FindObjectOfType<TestController>();
        PoolManager.instance.CreatePool(blueSphere, pooledAmount);

    }

    public void BlueFire()
    {
        testController.BlueButtonClicked();
        testController.ObjectButtonClicked();

        PoolManager.instance.ReuseObject(blueSphere, boxTransform.position, boxTransform.rotation);
    }

    public override void OnObjectReuse()
    {
        transform.localScale = Vector3.one;
    }
}
