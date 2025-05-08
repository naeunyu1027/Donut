using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ground : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject gameover;
    private int score = 5;
    public GameObject player;
    public GameObject spawner;

    GameController heartController;
    void Start()
    {
        SetText();
        heartController = FindObjectOfType<GameController>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("donut"))
        {
            DecreaseScore();
        }
    }

    public void DecreaseScore()
    {
        if (score > 0)
        {
            score -= 1;
            SetText();
        }
        if (score == 0)
        {
            spawner.SetActive(false);
            player.SetActive(false);
            gameover.SetActive(true);
        }
      
    }

    public void SetText()
    {
        text.text = "heart: " + score.ToString();
    }
}
