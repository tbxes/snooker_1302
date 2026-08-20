using UnityEngine;


public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
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
