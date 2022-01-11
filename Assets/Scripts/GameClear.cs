using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    Transform myTransform;
    public Text gameClearMessage;
    bool isGameClear = true;
    // Start is called before the first frame update
    void Start()
    {
        // マイフレームアクセスするため、変数に一度保存しておく
        
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (myTransform.childCount == 0)
        {
            gameClearMessage.text = "Game Clear!";
            Time.timeScale = 0f;
            isGameClear = true;
        }

        if (isGameClear && Input.GetButtonDown("Submit"))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Play");
        }
    }
}
