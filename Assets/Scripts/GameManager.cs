using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
internal class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI titleText;
    public bool isAvtive;
    public Button start;
    public Button restart;
    // Start is called before the first frame update
    void Start()
    {
        score= 0;
        UpdateScore(0);
    }
    // Update is called once per frame
    void Update()
    {
        if(score==10)
        {
            winText.gameObject.SetActive(true);
            isAvtive= false;
            restart.gameObject.SetActive(true);
        }
    }
    public void UpdateScore(int add)
    {
        score += add;
        scoreText.text = "Score: " + score;
    }
    public void StartGame()
    {
        titleText.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
        isAvtive= true;
        scoreText.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

