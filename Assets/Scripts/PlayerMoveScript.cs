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
    private float gravity = -9.8f;
    [SerializeField]
    private float rotateAmount;
    [SerializeField]
    private Animator player_animator;

    private string WALK_PARAM = "walk";
    //private string PUSH_PARAM = "push";

    private Vector3 velocity;

    private void Start()
    {
        player_animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        velocity.y += gravity * Time.deltaTime;
        //RotatePlayer();
    }
    private void FixedUpdate()
    {
        MoveCharacter();
    }
    void MoveCharacter()
    {
        vectorMovement = characterController.transform.forward * vertical;
        characterController.transform.Rotate(Vector3.up * rotateAmount * horizontal *Time.deltaTime);
        AnimatePlayer();
        characterController.Move(vectorMovement * moveSpeed * Time.deltaTime);
        characterController.Move(velocity * Time.deltaTime);

    }
    void AnimatePlayer()
    {
        if (vertical != 0) {
            player_animator.SetBool(WALK_PARAM, true);
        }
        if (vertical == 0)
        {
            player_animator.SetBool(WALK_PARAM, false);
        }

        if (horizontal != 0)
        {
            player_animator.SetBool(WALK_PARAM, true);
        }
        
    }
    void RotatePlayer()
    {
        
    }
}
