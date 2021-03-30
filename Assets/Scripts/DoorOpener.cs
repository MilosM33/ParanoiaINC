using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hello");
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
