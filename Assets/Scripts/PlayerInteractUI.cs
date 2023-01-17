using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObj;
    [SerializeField] private PlayerInteract playerinteract;

    private void Update()
    {
        if (playerinteract.GetNPCInteractable() != null)
        {
            Show();
        }
        else
        {
            Hide(); 
        }
    }
    public void Show() {
        containerGameObj.SetActive(true);
    }

    public void Hide()
    {
        containerGameObj.SetActive(false);
    }
}
