using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameoverui;
    private bool isGameOver = false;

    void Start()
    {
        update();
        gameoverui.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Addscore(int point)
    {
        if (!isGameOver)
        {
            score += point;
            update();
        }
    }
    public void update()
    {
        scoreText.text=score.ToString();
    }
    public void gameover()
    {
        isGameOver=true;
        score = 0;
        Time.timeScale = 0;
        gameoverui.SetActive(true);
    }
    public void restartGame()
    {
        isGameOver = false;
        score = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public bool IsgameOver() 
    {
        return isGameOver;
    }
}
