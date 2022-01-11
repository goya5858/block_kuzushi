using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text gameOverMessage;
    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver && Input.GetButtonDown("Submit"))
        {
            SceneManager.LoadScene("Play");
        }
    }

    // 衝突時
    private void OnCollisionEnter(Collision collision)
    {
        gameOverMessage.text = "Game Ovew";
        // 衝突した物体のgameObjectを削除する
        Destroy( collision.gameObject );
        isGameOver = true;
    }
}
