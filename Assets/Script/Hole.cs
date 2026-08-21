using UnityEngine;


public class Hole : MonoBehaviour
{

    SnookerAudio audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<SnookerAudio>();
    }
    private void OnTriggerEnter(Collider other)
    {

        audioManager.PlaySFX(audioManager.hole);

        Ball b = other.GetComponent<Ball>();

        if (b != null)
        {
            if (b.Point == 0)
            {
                GameManager.instance.ShowString($"OMG you drop your ball!!!\n You lose ka!!!");
                    Time.timeScale = 0f; 
            }

            else
            {
                GameManager.instance.ShowScoreText(b.Point);
            }
            Destroy(b.gameObject);
        }
    }
}
