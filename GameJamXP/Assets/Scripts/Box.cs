using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField]
    private bool _Fill;
    public int _id;
    public int _value;
    public string _tagCard;
    public string _nameObject;
    public string _nameAccesory;

    public void Check(int id, int value)
    {
        _Fill = true;
        _id = id;
        _value = value;
    }

    public void CleanBox()
    {
        _Fill = false;
        _id = 0;
    }
}