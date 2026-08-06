using UnityEngine;

public enum BallColor
{
    White,
    Red,
    Ywllow,
    Green,
    Brown,
    Blue,
    Pink,
    Black
}

public class Ball : MonoBehaviour
{
    [SerializeField]
    private int point;

    [SerializeField]
    private BallColor color;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
