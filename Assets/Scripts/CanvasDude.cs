using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDude : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel = null;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanelOff();
    }

    public void gameOverPanelOff()
    {
        gameOverPanel.SetActive(false);
    }

    public void gameOverPanelOn()
    {
        gameOverPanel.SetActive(true);
    }
}
