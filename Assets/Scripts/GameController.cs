using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverPanel;
    public GameObject gameCompletePanel;
    void Start()
    {
        gameOverPanel.SetActive(false);
        gameCompletePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver() {
        gameOverPanel.SetActive(true);
    }

     public void GameCompleted() {
        gameCompletePanel.SetActive(true);
    }
}
