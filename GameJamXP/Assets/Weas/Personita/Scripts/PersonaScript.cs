using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonaScript : MonoBehaviour
{
    public int chisteHecho;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (chisteHecho)
        {
            case 0:
                StartCoroutine(ChisteDefault());
                break;

            case 1:
                StartCoroutine(ChisteBueno());
                break;
             
            case 2:
                StartCoroutine(ChisteMalo());
                break;

        }
        
    }

    IEnumerator ChisteBueno()
    {
        animator.SetBool("bueno", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("bueno", false);
        chisteHecho = 0;
    }
        IEnumerator ChisteMalo()
    {
        animator.SetBool("malo", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("malo", false);
        chisteHecho = 0;
    }
    
        IEnumerator ChisteDefault()
    {
        animator.SetBool("bueno", false);
        animator.SetBool("malo", false);
        yield return new WaitForSecondsRealtime(0);
    }
}
