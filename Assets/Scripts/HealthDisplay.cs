using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    TMP_Text scoretext;
    Player player;
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<TMP_Text>();
        player = FindObjectOfType<Player>();
        slider = FindObjectOfType<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = player.GetHealth().ToString();
        slider.value = player.GetHealth();
    }
}
