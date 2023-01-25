using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float hInput;
    float vInput;
    [SerializeField] private float speed = 8.0f;
    [SerializeField] private GameObject model = null;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if(hInput == 0)
        {
            model.transform.Rotate(0, 0, -model.transform.rotation.z * 2.0f);
        }


        model.transform.Rotate(0, 0, hInput * (Mathf.Abs(model.transform.rotation.z) - 0.20f));

        Debug.Log("Math: " + (Mathf.Abs(model.transform.rotation.z) - 0.2f));
        Debug.Log("Z: " + model.transform.rotation.z);


        Vector3 movement = new Vector3(0, vInput, hInput) * Time.deltaTime * speed * 100;

        rb.velocity = movement;
    }
}
