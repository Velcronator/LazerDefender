using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{

    TMP_Text scoretext;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<TMP_Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogError(player.GetHealth().ToString());
        scoretext.text = player.GetHealth().ToString();
    }
}
