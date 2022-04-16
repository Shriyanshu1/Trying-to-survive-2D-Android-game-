using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public Canvas main;
    public Canvas gameOverCanvas;
    public bool gameOver;
    public AudioSource explosion;
        // Start is called before the first frame update
    void Start()
    {

        gameOver = false;
        
        main.gameObject.SetActive(true);
        gameOverCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            gameOverCanvas.gameObject.SetActive(true);
            main.gameObject.SetActive(false);
        }
    }
    public void blast()
    {
        explosion.Play();
    }
}
