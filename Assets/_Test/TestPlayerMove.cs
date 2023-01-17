using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMove : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    [SerializeField]
    private float m_Speed;
    private float x;
    private float z;


    //private Animator player_animator;
    private string WALK_PARAM = "walk";
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //player_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * m_Speed * Time.deltaTime;
        z = Input.GetAxis("Vertical") * m_Speed * Time.deltaTime;
        MoveCharacter();
    }
    void AnimatePlayer()
    {
        if (z > 0)
        {
            //player_animator.SetBool(WALK_PARAM, true);
        }
        else if (z == 0)
        {
            //player_animator.SetBool(WALK_PARAM, false);
        }
    }
    void MoveCharacter()
    {
        Vector3 desiredVelocity = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
        //AnimatePlayer();
        m_Rigidbody.velocity = Vector3.Lerp(m_Rigidbody.velocity, desiredVelocity, Time.deltaTime * m_Speed);


        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
        //    transform.Rotate(new Vector3(0, 0, 0) * m_Speed, Space.World);
        //    player_animator.SetBool(WALK_PARAM, true);
        //    m_Rigidbody.velocity = transform.forward * m_Speed;
        //}
        //if (Input.GetKeyUp(KeyCode.UpArrow))
        //{
        //    player_animator.SetBool(WALK_PARAM, false);
        //}

        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    transform.Rotate(new Vector3(0, 180, 0) * m_Speed, Space.World);
        //    player_animator.SetBool(WALK_PARAM, true);
        //    //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
        //    m_Rigidbody.velocity = -transform.forward * m_Speed;
        //}
        //if (Input.GetKeyUp(KeyCode.DownArrow))
        //{
        //    player_animator.SetBool(WALK_PARAM, false);
        //}

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    //Rotate the sprite about the Y axis in the positive direction
        //    transform.Rotate(new Vector3(0, 90, 0) * m_Speed, Space.World);
        //}

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    //Rotate the sprite about the Y axis in the negative direction
        //    transform.Rotate(new Vector3(0, 180, 0) * m_Speed, Space.World);
        //}
    }
}
