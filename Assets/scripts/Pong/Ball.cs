using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private Rigidbody rb = null;
    public float goalDistance = -20;

    public void Launch(Vector3 dir, float speed)
    {
        rb.AddForce(dir * speed * 100);
    }
    public void start()
    {
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }


    // Start is called before the first frame update
    void Start()
    {
        //launch(GetRandomBallDir(), speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
