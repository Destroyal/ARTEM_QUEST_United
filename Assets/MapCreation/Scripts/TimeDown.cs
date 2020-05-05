using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDown : MonoBehaviour
{
    //firt condition of gameover: timeout (result: failure)
    
    /* second condition: ???
     *  for example: Completed the mission, so the game is over (result: success)
     * */

    //Time needed (when time=0, Game out)
    public float CountDownTime;
    private float GameTime;
    private float timer = 0;
    public Text GameCountTimeText;
    // Start is called before the first frame update
    public Button Quit;
    public Button Reload;
    public Text CoinGet;
    public Text CoinText;
    public Text TimeText;
    public GameObject gameoverPanel;

    void Start()
    {
        GameTime = CountDownTime;
    }
 
    // Update is called once per frame
    void Update()
    {
        int M = (int)(GameTime / 60);
        float S = GameTime % 60;
        timer += Time.deltaTime;
        if(timer>=1f)
        {
            timer = 0;
            GameTime--;
            GameCountTimeText.text = M + "：" + string.Format("{0:00}", S);
            Debug.Log(timer);
        }
        if (GameTime <= 0f)
        {
            GameCountTimeText.text =string.Format("{0:00}", 0);
            ShowGameOver(M, S);
        }
            //ShowGameOver(M, S);
            //gameoverPanel.SetActive(true);
    }

    public void ShowGameOver(int M, float S)
    {
        
        Time.timeScale = 0;
        gameoverPanel.SetActive(true);
        CoinText.text = CoinGet.text;
        //show the rest time
        //TimeText.text = M + "：" + string.Format("{0:00}", S);  
        // show time out:
        TimeText.text = "Time out!";
    }
    public void Back()
    {
        Time.timeScale = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuPrincipal");
    }
}
