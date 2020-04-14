using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController Instance;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        audioSource = this.GetComponent<AudioSource>();
    }
    public void CheckMusic()
    {
        if (PlayerPrefs.GetInt(GamePreference.Music) == 1)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }

}
