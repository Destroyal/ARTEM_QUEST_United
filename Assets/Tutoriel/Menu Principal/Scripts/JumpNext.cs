using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpNext : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    public FadeOut script;
    public void JumpNext_f()
    {
        audio.Play();
        StartCoroutine(aled());
        script.enabled = true;
    }

    private IEnumerator aled()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Bureau2");
    }
}
