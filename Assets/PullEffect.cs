using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PullEffect : MonoBehaviour
{
    public Transform PortalCoreTransform; // The transform the player will be pulled towards MANUALLY ADDED OR BY FIND FUNCTION maybe there's a need to turn off the target collider
    public float pullForce = 2f; // The force of the pull
    public Transform XRorigin; // the VR headset TODO change to private 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // make sure to add Player tag to the Headset (the parent) 
        {
            XRorigin = other.GetComponent<Transform>();
            Vector3 target = new Vector3(PortalCoreTransform.position.x, XRorigin.position.y, PortalCoreTransform.position.z);
            Vector3 pullDirection = target- XRorigin.position;
            XRorigin.Translate(pullDirection.normalized * pullForce, Space.World);
            // SceneManager.LoadScene(targetSceneID);  // TODO create new scene and add to build and update code here
            // turn off portal musix 
        }
    }




}   



