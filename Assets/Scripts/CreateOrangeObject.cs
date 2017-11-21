using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateOrangeObject : PoolObject {

    public GameObject orangeSphere;
    private TestController testController;
    public Transform boxTransform;
    private int pooledAmount = 20;


    // Use this for initialization
    void Start()
    {
        testController = FindObjectOfType<TestController>();
        PoolManager.instance.CreatePool(orangeSphere, pooledAmount);

    }

    public void OrangeFire()
    {
        testController.OrangeButtonClicked();
        testController.ObjectButtonClicked();

        PoolManager.instance.ReuseObject(orangeSphere, boxTransform.position, boxTransform.rotation);
    }

    public override void OnObjectReuse()
    {
        transform.localScale = Vector3.one;
    }
}
