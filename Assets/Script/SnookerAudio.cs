using UnityEngine;

public class SnookerAudio : MonoBehaviour
{
    [Header("───────────── Audio Source ─────────────")]
    [SerializeField]
    AudioSource musicSource;

    [SerializeField]
    AudioSource SFXsource;

    [Header("───────────── Audio Clip ─────────────")]
    public AudioClip background;
    public AudioClip ball;

    public AudioClip hole;


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
