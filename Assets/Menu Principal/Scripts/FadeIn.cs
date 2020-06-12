using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public GameObject noir;
    public AudioSource audio;
    public float fadeTime;
    
    private float elapsedTime;
    private Image img;
    private float alpha;
    private float init_volume;
    // Start is called before the first frame update
    void Start()
    {
        init_volume = audio.volume;
        audio.volume = 0;
        elapsedTime = 0;
        alpha = 1;
        img = noir.GetComponent<Image>();
        StartCoroutine(DoFadeOut());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DoFadeOut()
    {
        while (alpha > 0)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime > 1)
            {
                alpha = (1 - (elapsedTime-1) / fadeTime);
                audio.volume = (elapsedTime / fadeTime)*init_volume;
                img.color = new Color(img.color.r, img.color.g, img.color.b, alpha);
            }
            yield return null;
        }
        noir.SetActive(false);

        yield return null;
    }

}
