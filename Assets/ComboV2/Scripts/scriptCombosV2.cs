using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCombosV2 : MonoBehaviour
{
    public int nivelCombo;

    /*
    Nivel de Combos:

    nivelCombo 1 = combo X2
    nivelCombo 2 = combo X3
    */

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (nivelCombo)
        {
            case 0:
            animator.SetBool("comboX2", false);
            animator.SetBool("comboX3", false);
            break;

            case 1:
            animator.SetBool("comboX2", true);
            animator.SetBool("comboX3", false);
            break;

            case 2:
            animator.SetBool("comboX3", true);
            animator.SetBool("comboX2", false);
            break;

        }
    }
}
