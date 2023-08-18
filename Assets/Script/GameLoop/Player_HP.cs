using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_HP : MonoBehaviour
{
    public GameObject Player;
    public int playerHealth = 5;
    public TMP_Text HPText;
    public int coinScore = 0;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        HealthUI();
        CoinScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        playerHealth--;
        if (playerHealth == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

        HealthUI();
    }

    public void GetCoins()
    {
        coinScore = coinScore + 5;

        CoinScoreUI();
    }

    void HealthUI()
    {
        HPText.text = "Life :" + playerHealth;
    }

    void CoinScoreUI() 
    {
        scoreText.text = "Coin :" + coinScore;
    }
}
