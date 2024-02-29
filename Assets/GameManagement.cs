using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{

    // �X�R�A�֘A
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

    // �Q�[���J�n�O�̏�Ԃɖ߂�
    private void Initialize()
    {
        // �X�R�A��0�ɖ߂�
        score = 0;

    }

    public void TimeManagement()
    {

        gameTime -= Time.deltaTime;
        seconds = (int)gameTime;
        //timerText.text = seconds.ToString();

        

    }

    // �X�R�A�̒ǉ�
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
