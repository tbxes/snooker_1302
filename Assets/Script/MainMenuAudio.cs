using UnityEngine;

public class MainMenuAudio : MonoBehaviour
{
    [Header("───────────── Audio Source ─────────────")]
    [SerializeField]
    AudioSource musicSource;

    [SerializeField]
    AudioSource SFXsource;

    [Header("───────────── Audio Clip ─────────────")]
    public AudioClip background;
    public AudioClip click;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXsource.PlayOneShot(clip);
    }
}
