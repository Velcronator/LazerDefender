using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    private int score = 0;

    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreAddValue)
    {
        score += scoreAddValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }


}
