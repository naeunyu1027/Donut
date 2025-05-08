using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class heartController : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int score = 5;

    public GameObject player;

    private void Start()
    {
        SetText();
    }

    public void DecreaseScore()
    {
        if (score > 0)
        {
            score -= 1;
            SetText();
        }
        if(score == 0)
        {
            player.SetActive(false);
        }
    }

    public void SetText()
    {
        text.text = "Score: " + score.ToString();
    }
}
