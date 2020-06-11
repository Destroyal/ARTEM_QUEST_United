using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredit : MonoBehaviour
{
    public GameObject title;
    public GameObject credits;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickCredits()
    {
        audio.Play();
        title.SetActive(false);
        credits.SetActive(true);
    }

    public void OnClickReturn()
    {
        audio.Play();
        credits.SetActive(false);
        title.SetActive(true);
    }
}
