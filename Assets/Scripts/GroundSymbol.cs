using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSymbol : MonoBehaviour
{
    public int puzzelSymbol;
    public int correctSymbol;
    public bool isActive;

    private float offset = 0.1f;

    [SerializeField] private GameObject fx;

    //[SerializeField] private bool requireAnswer;
    //private SymbolID matchingBox;

    private void Start()
    {
        isActive = false;
        fx.gameObject.SetActive(false);
        //if(requireAnswer)
        //{
        //    isActive = false;
        //}
        //else
        //{
        //    isActive = true;
        //}
    }

    private void Update()
    {
        if(isActive)
        {
            fx.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PuzzelBox"))
        {
            //Debug.Log("collision");
            if (Mathf.Abs(transform.position.x - other.gameObject.transform.position.x) <= offset && Mathf.Abs(transform.position.z - other.gameObject.transform.position.z) <= offset)
            {
                //Debug.Log("box position:" + transform.position.x);
                //Debug.Log("symbol position:" + collision.gameObject.transform.position.x);
                //Debug.Log("diff: " + (transform.position.x - other.gameObject.transform.position.x));

                if(!isActive)
                {
                    isActive = true;
                    puzzelSymbol = other.gameObject.GetComponent<SymbolID>().ID;
                    Debug.Log("perfect allignment");
                }
            }
            else
            {
                isActive = false;
                puzzelSymbol = 0;
                Debug.Log("oh no!");
            }

        }
    }
}
