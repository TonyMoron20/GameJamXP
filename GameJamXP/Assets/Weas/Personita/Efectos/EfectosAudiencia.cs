using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosAudiencia : MonoBehaviour
{

    public int chisteHechoEfecto;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
        void Update()
    {
        switch (chisteHechoEfecto)
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
        animator.SetBool("risa", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("risa", false);
        chisteHechoEfecto = 0;
    }
        IEnumerator ChisteMalo()
    {
        animator.SetBool("abucheo", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("abucheo", false);
        chisteHechoEfecto = 0;
    }
    
        IEnumerator ChisteDefault()
    {
        animator.SetBool("risa", false);
        animator.SetBool("abucheo", false);
        yield return new WaitForSecondsRealtime(0);
    }
}
