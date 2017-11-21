using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour
{


    Rigidbody _rigidBody;
    private int xNumber;
    private int yNumber;
    private int zNumber;
    private int speed;



    void Start()
    {
        _rigidBody = this.GetComponent<Rigidbody>();

        xNumber = Random.Range(-100, 100);
        yNumber = Random.Range(-100, 100);
        zNumber = Random.Range(-100, 100);
        speed = Random.Range(1, 50);


        if (_rigidBody == null)
        {
            Debug.LogError("Rigid body could not be found.");
        }

        if (_rigidBody != null)
        {
            Vector3 moveVector = new Vector3(xNumber, yNumber, zNumber) * speed;
            _rigidBody.AddForce(moveVector, ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {
 
    }

}