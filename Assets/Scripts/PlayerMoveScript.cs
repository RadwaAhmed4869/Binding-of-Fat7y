using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    [SerializeField]
    private CharacterController characterController;
    [SerializeField]
    private float moveSpeed = 12.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        MoveCharacter();
    }
    void MoveCharacter()
    {
        Vector3 newPos = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(newPos * moveSpeed * Time.deltaTime);
    }
}
