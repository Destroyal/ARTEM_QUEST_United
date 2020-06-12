using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    public FadeOut script;
    public void Exit_f()
    {
        audio.Play();
        StartCoroutine(w82kill());
        script.enabled = true;

    }

    private IEnumerator w82kill()
    {
        yield return new WaitForSeconds(3);
        Application.Quit();
    }
}
