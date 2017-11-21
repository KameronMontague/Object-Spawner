using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRedObject : PoolObject {


    public GameObject redSphere;
    private TestController testController;
    public Transform boxTransform;
    private int pooledAmount = 20;


    // Use this for initialization
    void Start () {      
        
        testController = FindObjectOfType<TestController>();        
        PoolManager.instance.CreatePool(redSphere, pooledAmount);

	}

    public void RedFire()
    {
        testController.RedButtonClicked();
        testController.ObjectButtonClicked();

        PoolManager.instance.ReuseObject(redSphere, boxTransform.position, boxTransform.rotation);
    }

    public override void OnObjectReuse()
    {
        transform.localScale = Vector3.one;
    }



}
