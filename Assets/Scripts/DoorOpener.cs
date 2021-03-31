using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Car"))
        {
            animator.SetBool("isOpen",true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name.Contains("Car"))
        {
            animator.SetBool("isOpen", false);
        }
    }

}
