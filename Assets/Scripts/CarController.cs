using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public float fwdSpeed;
    public float revSpeed;
    public float turnSpeed;
    public float Accelerate = 2;
    public float Force = 1;
    public float Distance = 1;
    Rigidbody rb = new Rigidbody();
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.queriesHitBackfaces = false;
    }

    private float lastHitDist;
    public float length = 1f;
    private float moveInput = 1;

    void Update()
    {
        float turnInput = Input.GetAxis("Horizontal");
        moveInput = Input.GetAxis("Vertical");

        moveInput *= moveInput > 0 ? fwdSpeed : revSpeed;

        float rotation = turnInput * turnSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(0,rotation,0,Space.World);
        

    }


    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.forward, out hit, Distance))
        {
            Debug.DrawRay(transform.position, -transform.forward);
            float forceAmount = HooksLawDampen(hit.distance);
            rb.AddForceAtPosition(transform.forward * forceAmount, transform.position);
        }
        else
        {
            lastHitDist = length * 1.1f;
        }

        
        rb.AddForce(-transform.up * moveInput,ForceMode.Acceleration);  
        

        //AntiGravity
    }

    public float strength = 1f;
    public float dampening = 1f;
    private float HooksLawDampen(float hitDistance)
    {
        float forceAmount = strength * (length - hitDistance) + (dampening * (lastHitDist - hitDistance));
        forceAmount = Mathf.Max(0, forceAmount);
        lastHitDist = hitDistance;
        return forceAmount;
    }
}
