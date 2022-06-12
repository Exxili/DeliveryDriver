using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverScript : MonoBehaviour
{
    // Note: Serialize Field makes a private variable
    // viewable in the inspector

    // Public variables can also be used, but this makes the
    // variable available to other scripts in the unity project
    public float steerSpeed = 1f;
    public float moveSpeed = 20f;
    public float slowSpeed = 10f;
    public float boostSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("Oops Hit a slowdown");
            moveSpeed = slowSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Boost")
        {
            Debug.Log("Hit A Booster");
            moveSpeed = boostSpeed;    
        } 
    }
}
