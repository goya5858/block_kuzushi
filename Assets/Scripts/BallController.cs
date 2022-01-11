using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        this.myRigidbody = GetComponent<Rigidbody>();
        this.myRigidbody.velocity = new Vector3(speed, speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
