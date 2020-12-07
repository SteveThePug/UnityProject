using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public void input()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
        if ((horizontal != 0) | (vertical != 0) | (jump != 0))
        {
            rb.AddForce(horizontal * thrust, jump * thrust, vertical * thrust, ForceMode.Impulse);
        }
        else
        {
            rb.velocity = Vector3.SmoothDamp(rb.velocity, new Vector3(0,-50,0), ref zero, (float)0.1 * thrust);
        }
    }
    public float thrust = 0.5f;
    public Rigidbody rb;
    public Transform tf;
    public Vector3 zero = Vector3.zero;

    void Start()
    {
        Debug.Log("hello world");
        rb.freezeRotation = true;
    }


    void Update()
    {
        input();
    }
}
