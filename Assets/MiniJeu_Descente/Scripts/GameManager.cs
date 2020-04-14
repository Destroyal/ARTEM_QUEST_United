using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int lifeCount1;
    public int coinCount1;
    public int score1;

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
    private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Gameplay")
        {
            GameController.Instance.SetScore(score1);
            GameController.Instance.SetLifeCount(lifeCount1);
            GameController.Instance.SetCoinCount(coinCount1);
            PlayerScore.LifeCount = lifeCount1;
            PlayerScore.CoinCount = coinCount1;
            PlayerScore.score = score1;
        }
    }
    public void CheckGameState(int lifeCount, int coinCount, int score)
    {
        if (lifeCount < 0)
        {
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
            lifeCount1 = lifeCount;
            coinCount1 = coinCount;
            score1 = score;
            SceneManager.LoadScene("GamePlay");
        }
    }
}
