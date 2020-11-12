using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreDisplay : MonoBehaviour
{
    TMP_Text scoretext;
    GameSession gameSession;
    
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<TMP_Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = gameSession.GetScore().ToString();
    }
}
