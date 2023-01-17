using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBoxScript : MonoBehaviour
{
    [SerializeField]
    private float forceMagnitude;
    private Animator character_animator;

    private string PUSH_PARAM = "push";
    private string BOX_TAG = "Box";
    private string PUSH_BOX_TAG = "pushBox";
    private bool isBox;
    private float rotateY;

    private void Start()
    {
        character_animator = GetComponent<Animator>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

            Rigidbody rigidbody = hit.collider.attachedRigidbody;
            if (rigidbody != null && hit.collider.CompareTag(BOX_TAG))
            {
                rigidbody.isKinematic = false;
                Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
                forceDirection.y = 0.0f;
                forceDirection.Normalize();

                rigidbody.AddForceAtPosition(forceDirection * forceMagnitude, transform.position, ForceMode.Impulse);
            }
       
            character_animator.SetBool(PUSH_PARAM, false);
        //rigidbody.isKinematic = true;
    }


    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag(PUSH_BOX_TAG))
        {
            Debug.Log("push");
             character_animator.SetBool(PUSH_PARAM, true);

        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(PUSH_BOX_TAG))
        {
            character_animator.SetBool(PUSH_PARAM, false);

        }
    }
}
