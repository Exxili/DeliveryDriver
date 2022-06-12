using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision Detected! - Ouch");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // If car collides with package, print "Got package" to console
        if (other.tag == "Package") 
        {
            Debug.Log("Got Package!");
        }

        // if car collides with customer, print "Delivered Package" to console
        if (other.tag == "Customer") 
        {
            Debug.Log("Delivered Package");
        }
    }
}
