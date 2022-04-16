using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelButton : MonoBehaviour
{
    public Text fuel;
    public int fuelcount;
    public Rigidbody2D rb;
    public UIcontroller obj;
    public bool gamestart;
    public AudioSource up;
    
    // Start is called before the first frame update
    void Start()
    {
        gamestart = false;
        fuelcount = 60; 
    }

    // Update is called once per frame
    void Update()
    {
        
        fuel.text = fuelcount.ToString();
    }

    public void fly()
    {
        if (fuelcount > 0 && gamestart==true)
        {
            fuelcount--;
            up.Play();
            rb.AddForce(Vector2.up * 55f);
        }
    }
}
