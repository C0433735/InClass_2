using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeliRotors : MonoBehaviour
{

    [SerializeField] private float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0,speed * Time.deltaTime * 100,0);
    }
}
