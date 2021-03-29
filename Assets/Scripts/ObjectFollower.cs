using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    public Vector3 Offset;
    public Transform Object;
    public float movementSpeed;
    public float rotationSpeed;
    void Update()
    {
        Vector3 newPosition = Object.position + Offset;
        transform.position = Vector3.MoveTowards(transform.position, newPosition, movementSpeed * Time.deltaTime);

        Quaternion newRotation = Quaternion.LookRotation((newPosition - transform.position).normalized);
        newRotation *= Quaternion.Euler(15,0,0);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * rotationSpeed);

    }
}
