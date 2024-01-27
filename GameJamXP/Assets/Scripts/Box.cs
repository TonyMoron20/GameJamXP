using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField]
    private bool _Fill;
    public int _value;

    public void Check(int id)
    {
        _Fill = true;
        _value = id;
    }

    public void CleanBox()
    { 
        _Fill = false;
        _value = 0;
    }
}
