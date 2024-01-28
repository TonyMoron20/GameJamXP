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

    private UIManager _uiManager;

    private void Start()
    {
        box1 = GameObject.Find("Box1").GetComponent<Box>();
        box2 = GameObject.Find("Box2").GetComponent<Box>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
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
            CardsDestroy(box1._nameObject, box2._nameAccesory);

            if(box1._tagCard.Equals(_uiManager.objeto) && box2._tagCard.Equals(_uiManager.accesorio))
            {
                Debug.Log("10 pts");
            }
            else if (box1._tagCard.Equals(_uiManager.objeto) || box2._tagCard.Equals(_uiManager.accesorio))
            {
                Debug.Log("5 pts");
            }
            else
            {
                Debug.Log("0 pts");
            }
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

    public void CardsDestroy(string _object, string _accesory)
    {
        Destroy(GameObject.Find(_object));
        Destroy(GameObject.Find(_accesory));
    }

    private void v1Puntos()
    {
        if (box1._tagCard.Equals("Persona"))
        {
            if (box2._tagCard.Equals("Varios"))
            {
                Debug.Log("10 pts");
            }
            else if (box2._tagCard.Equals("Estetico") || box2._tagCard.Equals("Repugnante"))
            {
                Debug.Log("5 pts");
            }
            else if (box2._tagCard.Equals("Arma"))
            {
                Debug.Log("0 pts");
            }
        }
        else if (box1._tagCard.Equals("Animal"))
        {
            if (box2._tagCard.Equals("Arma"))
            {
                Debug.Log("10 pts");
            }
            else if (box2._tagCard.Equals("Varios") || box2._tagCard.Equals("Estetico"))
            {
                Debug.Log("5 pts");
            }
            else if (box2._tagCard.Equals("Repugnante"))
            {
                Debug.Log("0 pts");
            }
        }
        else if (box1._tagCard.Equals("Cosa"))
        {
            if (box2._tagCard.Equals("Estetico"))
            {
                Debug.Log("10 pts");
            }
            else if (box2._tagCard.Equals("Repugnante") || box2._tagCard.Equals("Arma"))
            {
                Debug.Log("5 pts");
            }
            else if (box2._tagCard.Equals("Varios"))
            {
                Debug.Log("0 pts");
            }
        }
    }
}