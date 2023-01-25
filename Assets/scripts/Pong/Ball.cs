using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float speed = 9f;
    [SerializeField] private Rigidbody rb = null;
    private float goalDistance = -20;

    public void launch(Vector3 dir, float speed)
    {
        rb.AddForce(dir * speed * 100);
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
        launch(GetRandomBallDir(), speed);
    }

    private Vector3 GetRandomBallDir()
    {
        int x = 1;
        int y = 1;
        if(Random.Range(0,2) == 0)
        {
            x = -1;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }

        return new Vector3(x, y, 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        launch(GetRandomBallDir(), speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > Mathf.Abs(goalDistance))
        {
            Reset();
        }else if(transform.position.x < goalDistance)
        {
            Reset();
        }
    }
}
