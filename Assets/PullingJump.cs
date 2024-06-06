using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    [SerializeField] float jumpPower = 10f;
    Rigidbody rb;
    Vector3 clickPosition;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector3 dragvector = clickPosition - Input.mousePosition;
            float size = dragvector.magnitude;
            rb.velocity = dragvector.normalized * jumpPower;

        }
      
    }
}

