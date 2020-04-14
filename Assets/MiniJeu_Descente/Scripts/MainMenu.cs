using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Sprite icon1;//sound open
    public Sprite icon2;//sound close
    public Image Music;
    // Start is called before the first frame update
    void Start()
    {
        CheckMusic();
    }
    void CheckMusic()
    {
        if (PlayerPrefs.GetInt(GamePreference.Music) == 1)
        {
            Music.sprite = icon1;
        }
        else
        {
            Music.sprite = icon2;
        }
        MusicController.Instance.CheckMusic();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void HighScore()
    {
        SceneManager.LoadScene("HighScore");
    }
    public void Options()
    {
        SceneManager.LoadScene("Option");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Sounds()
    {
        var state = PlayerPrefs.GetInt(GamePreference.Music);
        if (state == 0)
        {
            PlayerPrefs.SetInt(GamePreference.Music, 1);
        }
        else
        {
            PlayerPrefs.SetInt(GamePreference.Music, 0);
        }
        CheckMusic();
    }
}
