using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == -7.0f)
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        if (transform.position.y < -5f)
        {
            Destroy(this.gameObject);
        }
    }
}