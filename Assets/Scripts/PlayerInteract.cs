using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField]private bool isInvoked;
    BoxInteractable boxInte;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            isInvoked = true;
            supInteract(isInvoked);

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            isInvoked = false;
            supInteract(isInvoked);
        }

    }

    public void supInteract(bool isInvo)
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out boxInte))
            {

                boxInte.Interact(isInvo);
            }
        }
    }

    public BoxInteractable GetNPCInteractable()
    {
        List<BoxInteractable> boxInteractablesList = new List<BoxInteractable>();
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out BoxInteractable boxInte))
            {
                boxInteractablesList.Add(boxInte);
                
            }
        }
        BoxInteractable closestBoxInteractable = null;
        foreach(BoxInteractable boxInteractable in boxInteractablesList) {
            if (closestBoxInteractable == null)
            {
                closestBoxInteractable = boxInteractable;
            }
            else
            {
                if (Vector3.Distance(transform.position, boxInteractable.transform.position) <
                    Vector3.Distance(transform.position, closestBoxInteractable.transform.position) )
                {
                    closestBoxInteractable = boxInteractable;
                }
            }
        }
        
        return closestBoxInteractable;
    }
}
