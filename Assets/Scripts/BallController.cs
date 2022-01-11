using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallController : MonoBehaviour
{
    public float speed = 10.0f;
    public float minSpeed = 9f;
    public float maxSpeed = 11f;
    Rigidbody myRigidbody;

    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        this.myRigidbody = GetComponent<Rigidbody>();
        this.myRigidbody.velocity = new Vector3(speed, speed, 0f);
        myTransform = transform; //transformコンポーネントをキャッシュとして保存
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = myRigidbody.velocity;
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        myRigidbody.velocity = velocity.normalized * clampedSpeed;
        // velocity.normalized 正規化された(大きさ１にした)ベクトル
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 playerPos = collision.transform.position;
            Vector3 ballPos = myTransform.position;

            // プレイヤーから見たボールの方向を計算
            Vector3 direction = (ballPos - playerPos).normalized;
            float playerSpeed = myRigidbody.velocity.magnitude;
            myRigidbody.velocity = direction * playerSpeed;
        }
    }
}
