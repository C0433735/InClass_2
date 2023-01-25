using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject player = null;
    [SerializeField] private int distanceFromPlayer = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x + distanceFromPlayer, player.transform.position.y, player.transform.position.z);
    }
}
