using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

internal class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score= 0;
        UpdateScore(0);
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void UpdateScore(int add)
    {
        score += add;
        scoreText.text = "Score: " + score;
    }
}

