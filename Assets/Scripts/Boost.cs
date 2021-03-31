using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float boostValue = 10;
    public void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>()?.AddForce(transform.forward * boostValue);
    }
}
