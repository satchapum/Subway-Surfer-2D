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
    // Start is called before the first frame update
    void Start()
    {
        HealthUI();
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

    void HealthUI()
    {
        HPText.text = "Life :" + playerHealth;
    }
}
