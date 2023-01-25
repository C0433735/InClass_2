using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 6.0f;
    float hInput;
    float vInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(0, vInput, hInput) * Time.deltaTime * speed * 100;
        rb.velocity = movement;
    }
}
