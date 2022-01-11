using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody myRigidbody;
    Vector3 f_position;
    Vector3 m_position;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.f_position = this.myRigidbody.position;
        this.m_position = Input.mousePosition; //マウスの位置を取得
        y = Mathf.Clamp( (this.m_position.y/20.0f - 7.0f), -5.0f, 5.0f);
        this.f_position.y = y; //マウスの位置を

        this.myRigidbody.position = this.f_position;
    }
}
