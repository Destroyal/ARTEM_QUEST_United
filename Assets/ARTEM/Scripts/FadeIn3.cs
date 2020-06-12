using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn3 : MonoBehaviour
{
    // the image you want to fade, assign in inspector
    public Image img;
    public CharacterMovement1 script;
    public GameObject Fade;
    public Text text;
    public AudioSource bg;
    private SurvivorScript surv_script;

    void Start()
    {
        surv_script = GameObject.Find("Survivor").GetComponent<SurvivorScript>();
        if (!surv_script.once) { 
        // fades the image out when you click
        StartCoroutine(FadeImage(true));
        surv_script.once = true;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            for (float i = 4; i >= 0; i -= (float) 0.4*Time.deltaTime)
            {
                // set color with i as alpha
                if (i <= 1) { 
                    img.color = new Color(0, 0, 0, i);
                    yield return null;
                }

                else if (i<2)
                {
                    text.color = new Color(1, 1, 1, (float) (i-1));
                    yield return null;
                }
                else if (i>=2)
                {
                    if (i < 3.75)
                    {
                        bg.enabled = true;
                    }
                    text.color = new Color(1, 1, 1, (float)(4-i)/2);
                    yield return null;
                }
            }
            script.is_stunned = false;
            Fade.SetActive(false);

        }
     
    }

}
