using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut2 : MonoBehaviour
{
    // the image you want to fade, assign in inspector
    public Image img;
    public AudioSource audio;
    public GameObject audio_door;
    private bool do_once;

    void Start()
    {
        // fades the image out when you click
        StartCoroutine(FadeImage2(true));
    }

    IEnumerator FadeImage2(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            
            for (float i = 0; i <= 1; i += (float)0.2 * Time.deltaTime)
            {
                // set color with i as alpha
                if (i <= 1)
                {
                    img.color = new Color(0, 0, 0, i);
                    audio.volume -= (float) (i/100);
                    if (i > 0.5 && !do_once)
                    {
                        audio_door.GetComponent<AudioSource>().Play();
                        do_once = true;
                    }
                    yield return null;

                }
                yield return null;
            }
            SceneManager.LoadScene("FullARTEM");

        }

    }
}
