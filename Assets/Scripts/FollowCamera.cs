using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject cameraTarget;

    // The Cameras position should be the same as the car's position
    void LateUpdate() 
    {
        transform.position = cameraTarget.transform.position + new Vector3(0, 0, -10);
    }
}
