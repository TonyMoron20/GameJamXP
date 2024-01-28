using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragItem : MonoBehaviour
{
    [SerializeField]
    private int _id;
    private bool _drag;
    private bool _inPosition = false;

    private void OnMouseDown()
    {
        _drag = true;
    }

    private void OnMouseUp()
    {
        _drag = false;
        if (!_inPosition)
        {
            Destroy(this.gameObject, 1);
        }
    }

    private void Update()
    {
        if (_drag) 
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePos);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Box box = collision.GetComponent<Box>();

        if(collision.CompareTag("Object") && _id > 0)
        {
            Debug.Log("Bien Objeto colocado");

            if (box != null)
            {
                box.Check(_id);
                box._tagCard = this.gameObject.tag;
                box._nameObject = this.gameObject.name;
            }

            _inPosition = true;
        }
        else if(collision.CompareTag("Accesory") && _id < 0)
        {
            Debug.Log("Bien accesorio colocado");
            if (box != null)
            {
                box.Check(_id);
                box._tagCard = this.gameObject.tag;
                box._nameAccesory = this.gameObject.name;
            }

            _inPosition = true;
        }
        else if(collision.CompareTag("Object") && _id < 0 || collision.CompareTag("Accesory") && _id > 0)
        {
            Debug.Log("Casilla erronea");
            Destroy(this.gameObject, 1);
        }
    }


}
