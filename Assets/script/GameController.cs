using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public Text text;
    int score = 0;

    private void Start()
    {
        SetText();
    }

   
    public void GetScore()
    {
        score += 1;
        SetText();
    }

    public void PlusGetScore()
    {
        score += 5;
        SetText();
    }

    public void dirtyGetScore()
    {
        score -= 5;
        SetText();
    }

    public void SetText()
    {
        text.text = "Score : " + score.ToString();
    }
}
