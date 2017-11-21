using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetectedAmount : MonoBehaviour {

    public Text totalCollisionDisplay;
    public int collisionCounter = 0;
    public static int counted;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "FloatingObject")
        {
            counted += 1;
            collisionCounter += 1; 
            totalCollisionDisplay.text = collisionCounter.ToString();            
            
        }

    }


}
