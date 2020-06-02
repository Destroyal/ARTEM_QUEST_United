using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //单例模式
    public static GameManager Instance;
    public int lifeCount1;
    public int coinCount1;
    public int score1;
    public bool gameRestart;
    //public bool gameStart;
    void Start()
    {

        if (Instance != null)
        {
            Object.Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    /*
    void OnLevelWasLoaded(int level)
    {
        //Debug.Log("level:"+level);
        if (SceneManager.GetActiveScene().name == "GamePlay")
        {
            GameController.Instance.SetScore(score1);
            GameController.Instance.SetLifeCount(lifeCount1);
            GameController.Instance.SetCoinCount(coinCount1);
            PlayerScore.LifeCount = lifeCount1;
            PlayerScore.CoinCount = coinCount1;
            PlayerScore.score = score1;
        }
    }
    */
    void OnEnable()
    {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "GamePlay")
        {
            if (gameRestart)
            {
                GameController.Instance.SetScore(score1);
                GameController.Instance.SetLifeCount(lifeCount1);
                GameController.Instance.SetCoinCount(coinCount1);
                PlayerScore.LifeCount = lifeCount1;
                PlayerScore.CoinCount = coinCount1;
                PlayerScore.score = score1;
            }
            else
            {
                GameController.Instance.SetScore(0);
                GameController.Instance.SetLifeCount(1);
                GameController.Instance.SetCoinCount(0);
                PlayerScore.LifeCount = 1;
                PlayerScore.CoinCount = 0;
                PlayerScore.score = 0;
            }
        }
    }
    public void CheckGameState(int lifeCount, int coinCount, int score)
    {
        if (lifeCount < 0)
        {
            //gameStart = false;
            gameRestart = false;
            var easy = PlayerPrefs.GetInt(GamePreference.Easy);
            if (easy == 1)
            {
                var highScore = PlayerPrefs.GetInt(GamePreference.EasyHighScore);
                var highCoin = PlayerPrefs.GetInt(GamePreference.EasyCoin);
                if (score > highScore)
                {
                    PlayerPrefs.SetInt(GamePreference.EasyHighScore, score);
                }
                if (coinCount > highCoin)
                {
                    PlayerPrefs.SetInt(GamePreference.EasyCoin, coinCount);
                }
            }
            var medium = PlayerPrefs.GetInt(GamePreference.Medium);
            if (medium == 1)
            {
                var highScore = PlayerPrefs.GetInt(GamePreference.MediumHighScore);
                var highCoin = PlayerPrefs.GetInt(GamePreference.MediumCoin);
                if (score > highScore)
                {
                    PlayerPrefs.SetInt(GamePreference.MediumHighScore, score);
                }
                if (coinCount > highCoin)
                {
                    PlayerPrefs.SetInt(GamePreference.MediumCoin, coinCount);
                }
            }
            var hard = PlayerPrefs.GetInt(GamePreference.Hard);
            if (hard == 1)
            {
                var highScore = PlayerPrefs.GetInt(GamePreference.HardHighScore);
                var highCoin = PlayerPrefs.GetInt(GamePreference.HardCoin);
                if (score > highScore)
                {
                    PlayerPrefs.SetInt(GamePreference.HardHighScore, score);
                }
                if (coinCount > highCoin)
                {
                    PlayerPrefs.SetInt(GamePreference.HardCoin, coinCount);
                }
            }
            lifeCount1 = 0;
            coinCount1 = 0;
            score1 = 0;
            GameController.Instance.ShowGameOver(score, coinCount);
        }
        else
        {
            this.lifeCount1 = lifeCount;
            this.coinCount1 = coinCount;
            this.score1 = score;
            //gameStart = false;
            gameRestart = true;
            SceneManager.LoadScene("GamePlay");
        }
    }
}
