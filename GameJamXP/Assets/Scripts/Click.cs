using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject clickAnimation;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(clickAnimation, mousePos + new Vector3(0,0, 10), Quaternion.identity);
        }
    }
}
