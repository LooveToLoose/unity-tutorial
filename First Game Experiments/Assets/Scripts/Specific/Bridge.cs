using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            animator.SetTrigger("Lower Bridge");
        }
    }
}
