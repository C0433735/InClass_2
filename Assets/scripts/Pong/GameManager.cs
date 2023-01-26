using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] Ball ball;
    [SerializeField] UIManager uiManager;
    int p1score = 0;
    int p2score = 0;
    [SerializeField] private float ballSpeed = 9f;

    private Vector3 GetRandomBallDir()
    {
        int x = 1;
        int y = 1;
        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }

        return new Vector3(x, y, 0);
    }


    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateScore(p1score, p2score);
        ball.Launch(GetRandomBallDir(), ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        bool timeToReset = false;
        if (ball.transform.position.x > Mathf.Abs(ball.goalDistance))
        {
            timeToReset = true;
            p1score++;
        }
        else if (ball.transform.position.x < ball.goalDistance)
        {
            timeToReset = true;
            p2score++;
        }

        if (timeToReset)
        {
            ball.Reset();
            uiManager.UpdateScore(p1score, p2score);
            ball.Launch(GetRandomBallDir(), ballSpeed);
        }
    }
}
