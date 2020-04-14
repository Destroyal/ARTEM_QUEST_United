using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //单例模式
    public static GameController Instance;


    public UnityEngine.UI.Text lifeCount;
    public Text coinCount;
    public Text score;
    public Button pause;
    public Button resume;
    public Button quit;

    public GameObject PausePanel;
    public GameObject ReadyPanel;

    public Text ScoreText;
    public Text CoinText;
    public GameObject gameoverpanel;
    public void SetLifeCount(int l)
    {
        lifeCount.text = "X" + l;
    }
    public void SetCoinCount(int c){
        coinCount.text ="X"+c;
    }
    public void SetScore(int s)
    {
        score.text = s.ToString();
    }
    public void PauseGame()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;

    }
    public void QuitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");

    }
    void Awake()
    {
        Instance = this;
        PausePanel.SetActive(false);
        Time.timeScale = 0;//pause in the beginning
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ShowGameOver(int score,int coin){
        Time.timeScale = 0;
        gameoverpanel.SetActive(true);
        ScoreText.text = score.ToString();
        CoinText.text = coin.ToString();
    }
    public void Back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void OnReady()
    {
        Time.timeScale = 1;
        ReadyPanel.SetActive(false);
    }
}

