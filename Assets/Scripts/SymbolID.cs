using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolID : MonoBehaviour
{
    [SerializeField] private int id;

    public int ID { get { return id; } }

    //public static implicit operator SymbolID(Collider v)
    //{
    //    throw new NotImplementedException();
    //}
}
