using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    public Color32 baseColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    bool hasPackage;

    public float DestroyDelay = 1f;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision Detected! - Ouch");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // If car collides with package, print "Got package" to console
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("Got Package!");
            hasPackage = true;

            // Update the color of the car to indicate you have picked up a package
            spriteRenderer.color = hasPackageColor;

            // Remove the Package from the world
            Destroy(other.gameObject, DestroyDelay);


            
        }

        // if car collides with customer, print "Delivered Package" to console
        if (other.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Delivered Package");
            
        // Update the color of the car to indicate you have delivered up a package
            spriteRenderer.color = baseColor;

            hasPackage = false;
        }
    }
}
