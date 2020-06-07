using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slider : MonoBehaviour
{
    public Transform player;
    public Scrollbar scr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scr.value = -player.position.y / 80;
        if(-player.position.y >=80)
        {
            SceneManager.LoadScene("FullARTEM");
        }
    }
}
