using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    private float _speed = 4f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == -6.8f)
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        if (transform.position.y < -6f)
        {
            Destroy(this.gameObject);
        }
    }
}
