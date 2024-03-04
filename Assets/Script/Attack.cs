using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        print("Start jalan");
        animator = GetComponent<Animator>();

    }

    void AttackNow()
    {
        animator.SetTrigger("goAttack");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)) 
        {
            print("has just Attacked");
            AttackNow();
        }
    }
}
