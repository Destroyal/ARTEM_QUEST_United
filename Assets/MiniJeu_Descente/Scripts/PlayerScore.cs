using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{

    public static int CoinCount = 0;
    public static int LifeCount = 0;
    public static int score = 0;
    // Start is called before the first frame update
    public AudioClip CoinSound;
    public AudioClip LifeSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //darkcloud has a box collider
        if (other.gameObject.tag == "DarkCloud")
        {
            var cs = Camera.main.GetComponent<CameraScript>();
            cs.enabled = false;
            transform.localPosition = new Vector3(1000, 1000, 0);
            GameController.Instance.ShowGameOver(score,CoinCount);
            LifeCount--;
            GameManager.Instance.CheckGameState(LifeCount, CoinCount, score);
        }
        if (other.gameObject.tag == "Bound")
        {
            var cs = Camera.main.GetComponent<CameraScript>();
            cs.enabled = false;
            transform.localPosition = new Vector3(1000, 1000, 0);
            //GameController.Instance.ShowGameOver(score, CoinCount);
            LifeCount--;
            GameManager.Instance.CheckGameState(LifeCount, CoinCount, score);
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Coin")
        {
            CoinCount++;
            target.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);

            GameController.Instance.SetCoinCount(CoinCount);

            score += 200;
            GameController.Instance.SetScore(score);

        }
        else if (target.tag == "Life")
        {
            LifeCount++;
            target.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(LifeSound, transform.position);
            GameController.Instance.SetLifeCount(LifeCount);
            score += 500;
            GameController.Instance.SetScore(score);
        }
    }

}
