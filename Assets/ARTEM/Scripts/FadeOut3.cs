using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut3 : MonoBehaviour
{
    // the image you want to fade, assign in inspector
    public Image img;
    public Image img2;
    public AudioSource audio;
    private GameObject survivor;

    void Start()
    {
        StartCoroutine(FadeImage(true));
        survivor = GameObject.Find("Survivor");
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            for (float i = 0; i <= 4; i += (float) 0.4*Time.deltaTime)
            {
                // set color with i as alpha
                    
                img.color = new Color(0, 0, 0, i/4);
                img2.color = new Color(1, 1, 1, i/4);
                yield return null;
             
                
            }

            for (float i = 4; i > 0; i -= (float)0.4 * Time.deltaTime)
            {
                // set color with i as alpha

                img2.color = new Color(1, 1, 1, i/4);
                audio.volume = audio.volume - i / 14000;
                yield return null;


            }
            Destroy(survivor);
            SceneManager.LoadScene("MenuPrincipal");

        }
     
    }

}
