using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 15.0f;
    [SerializeField] string axis = "VerticalP1";
    private Rigidbody rb;
    //float hInput;
    float vInput;
    float yLimit = -4;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        //hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxisRaw(axis);
    }
    private void FixedUpdate()
    {
        if ((!(transform.position.y > Mathf.Abs(yLimit)) && !(vInput < 0)) || (!(transform.position.y < yLimit) && !(vInput > 0)))
        {
            Vector3 movement = Vector3.up * vInput * Time.deltaTime * speed;
            rb.transform.Translate(movement);
        }
        
        
    }
}
