using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int PlayerScore;
    public int PlaqyerScore { get { return PlayerScore;  } set { PlayerScore = value; } }

    public static GameManager instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
