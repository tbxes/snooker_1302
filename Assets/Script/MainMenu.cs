using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    MainMenuAudio audioManager;

    private void Awake()
    {
        GameObject audioObj = GameObject.FindGameObjectWithTag("Audio2");
        if (audioObj != null)
        {
            audioManager = audioObj.GetComponent<MainMenuAudio>();
        }
    }

    public void Startgame()
    {
        StartCoroutine(PlaySoundAndStart());
    }

    IEnumerator PlaySoundAndStart()
    {
        if (audioManager != null && audioManager.click != null)
        {
            audioManager.PlaySFX(audioManager.click);
        
            yield return new WaitForSeconds(audioManager.click.length);
        }

        SceneManager.LoadScene("Loading");
    }

    public void Exit()
    {
        Application.Quit();
    }
}