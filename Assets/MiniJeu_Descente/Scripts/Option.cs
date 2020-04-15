using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public GameObject easySign, mediumSign, hardSign;
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }
    void Init()
    {
        var easy = PlayerPrefs.GetInt(GamePreference.Easy);
        if (easy == 1)
        {
            easySign.SetActive(true);
            mediumSign.SetActive(false);
            hardSign.SetActive(false);
        }
        var medium = PlayerPrefs.GetInt(GamePreference.Medium);
        if (medium == 1)
        {
            easySign.SetActive(false);
            mediumSign.SetActive(true);
            hardSign.SetActive(false);
        }
        var hard = PlayerPrefs.GetInt(GamePreference.Hard);
        if (hard == 1)
        {
            easySign.SetActive(false);
            mediumSign.SetActive(false);
            hardSign.SetActive(true);
        }
    }
    public void SetEasy()
    {
        PlayerPrefs.SetInt(GamePreference.Easy, 1);
        PlayerPrefs.SetInt(GamePreference.Medium, 0);
        PlayerPrefs.SetInt(GamePreference.Hard, 0);
        Init();

    }
    public void SetMedium()
    {
        PlayerPrefs.SetInt(GamePreference.Easy, 0);
        PlayerPrefs.SetInt(GamePreference.Medium, 1);
        PlayerPrefs.SetInt(GamePreference.Hard, 0);
        Init();
    }
    public void SetHard()
    {
        PlayerPrefs.SetInt(GamePreference.Easy, 0);
        PlayerPrefs.SetInt(GamePreference.Medium, 0);
        PlayerPrefs.SetInt(GamePreference.Hard, 1);
        Init();
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
