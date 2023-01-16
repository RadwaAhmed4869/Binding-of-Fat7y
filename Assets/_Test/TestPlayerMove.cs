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
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * m_Speed * Time.deltaTime;
        z = Input.GetAxis("Vertical") * m_Speed * Time.deltaTime;
        MoveCharacter();
    }
    void MoveCharacter()
    {
        //Vector3 desiredVelocity = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
        //rb.velocity = Vector3.Lerp(rb.velocity, desiredVelocity, Time.deltaTime * moveSpeed);


        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            transform.Rotate(new Vector3(0, 0, 0) * m_Speed, Space.World);
            m_Rigidbody.velocity = transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(0, 180, 0) * m_Speed, Space.World);
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * m_Speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 90, 0) * m_Speed, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -90, 0) * m_Speed, Space.World);
        }
    }
}
