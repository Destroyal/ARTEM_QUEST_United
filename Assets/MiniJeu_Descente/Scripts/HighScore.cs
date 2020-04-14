using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HighScore : MonoBehaviour
{
    public Text score;
    public Text coin;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }
    void Init()
    {
        var easy=PlayerPrefs.GetInt(GamePreference.Easy);
        if (easy == 1)
        {
            var s = PlayerPrefs.GetInt(GamePreference.EasyHighScore);
            var c = PlayerPrefs.GetInt(GamePreference.EasyCoin);
            score.text = s.ToString();
            coin.text = c.ToString();
        }
        var medium = PlayerPrefs.GetInt(GamePreference.Medium);
        if (medium == 1)
        {
            var s = PlayerPrefs.GetInt(GamePreference.MediumHighScore);
            var c = PlayerPrefs.GetInt(GamePreference.MediumCoin);
            score.text = s.ToString();
            coin.text = c.ToString();
        }
        var hard = PlayerPrefs.GetInt(GamePreference.Hard);
        if (hard == 1)
        {
            var s = PlayerPrefs.GetInt(GamePreference.HardHighScore);
            var c = PlayerPrefs.GetInt(GamePreference.HardCoin);
            score.text = s.ToString();
            coin.text = c.ToString();
        }
        if (easy == 0 && medium == 0 && hard == 0)
        {
            score.text = "0";
            coin.text = "0";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
