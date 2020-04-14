using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePreference : MonoBehaviour
{
    //difficult level
    //highest score
    //quantity of golden coins
    public static string Easy = "Easy";
    public static string Medium = "Medium";
    public static string Hard = "Hard";

    public static string EasyHighScore = "EasyHighScore";
    public static string MediumHighScore = "MediumHighScore";
    public static string HardHighScore = "HardHighScore";

    public static string EasyCoin = "EasyCoin";
    public static string MediumCoin = "MediumCoin";
    public static string HardCoin = "HardCoin";
    public static string Music = "Music";

    // Start is called before the first frame update
    void Start()
    {
        //var score = PlayerPrefs.GetInt("score");
        //Debug.Log(score);
        //PlayerPrefs.SetInt("score", 1000);
        /*
        PlayerPrefs.SetInt(Easy, 0);
        PlayerPrefs.SetInt(Easy, 1);
        PlayerPrefs.SetInt(EasyHighScore, 200);
        */
        //PlayerPrefs.SetInt(EasyCoin,1000);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
