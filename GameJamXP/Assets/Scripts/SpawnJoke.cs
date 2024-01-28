using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnJoke : MonoBehaviour
{
    private Box box1;
    private Box box2;

    [SerializeField]
    private GameObject objectJoke;

    private void Start()
    {
        box1 = GameObject.Find("Box1").GetComponent<Box>();
        box2 = GameObject.Find("Box2").GetComponent<Box>();
    }

    public void CheckBoxes()
    {
        int valueT = 0;

        if (box1._value != 0 && box2._value != 0)
        {
            valueT = box1._value + box2._value;
            Debug.Log($"Se spawneo el objeto {valueT}");
            Instantiate(objectJoke, new Vector3(1, -2, 0), Quaternion.identity);
            Clean();
        }
        else if(box1._value != 0 && box2._value == 0)
        {
            Debug.Log("Te hace falta colocar un accesorio");
        }
        else if (box1._value == 0 && box2._value != 0)
        {
            Debug.Log("Te hace falta colocar un objeto");
        }
        else
        {
            Debug.Log("Coloca algo en las casillas");
        }
    }

    private void Clean()
    {
        box1.CleanBox();
        box2.CleanBox();
    }
}