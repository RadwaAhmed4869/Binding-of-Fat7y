using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    private float horizontal;
    private float vertical;

    private Vector3 vectorMovement;
    private Vector3 vectorVelocity;

    private float mouseX;
    [SerializeField]
    private CharacterController characterController;
    [SerializeField]
    private float moveSpeed = 12.0f;
    [SerializeField]
    private float gravity = 0f;
    [SerializeField]
    private float rotateAmount;
   
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        //RotatePlayer();
    }
    private void FixedUpdate()
    {
        MoveCharacter();
    }
    void MoveCharacter()
    {
        vectorMovement = characterController.transform.forward * horizontal;
        characterController.transform.Rotate(Vector3.up * rotateAmount * vertical *Time.deltaTime);
        
        characterController.Move(vectorMovement * moveSpeed * Time.deltaTime);


    }
    void RotatePlayer()
    {
        
    }
}
