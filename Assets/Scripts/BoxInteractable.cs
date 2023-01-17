using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteractable : MonoBehaviour
{
    //[SerializeField] private Camera supCamera;
    //[SerializeField] private float smoothSpeed = 0.125f;
    //[SerializeField] private Vector3 offset;
    //Vector3 followVelocity;

    [SerializeField] private GameObject flashlight;


    public void Interact(bool isInvoked)
    {
        if (isInvoked)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            flashlight.gameObject.SetActive(true);
        }
        else if (!isInvoked)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            flashlight.gameObject.SetActive(false);
        }


        //supCamera.gameObject.SetActive(true);
        //Vector3 desiredPosition = transform.position + offset;
        //Vector3 smoothedPosition = Vector3.Slerp(supCamera.transform.position, desiredPosition, smoothSpeed);
        //supCamera.transform.position = desiredPosition;
        //supCamera.transform.LookAt(transform.position);

        Debug.Log("interact");

    }


}
