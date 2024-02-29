using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{

    // スコア関連
    public Text scoreText;

    private int score;

    public GameObject gamePauseUI;

    //public Text timerText;

    public float gameTime = 60f;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        TimeManagement();
    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;

    }

    public void TimeManagement()
    {

        gameTime -= Time.deltaTime;
        seconds = (int)gameTime;
        //timerText.text = seconds.ToString();

        

    }

    // スコアの追加
    public void AddScore()
    {
        score += 100;
        scoreText.text = "Score:" + score.ToString();

        Debug.Log("Add 100");

    }

    public void GamePause()
    {

        GamePauseToggle();

    }

    public void GamePauseToggle()
    {
        gamePauseUI.SetActive(!gamePauseUI.activeSelf);

        if (gamePauseUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
