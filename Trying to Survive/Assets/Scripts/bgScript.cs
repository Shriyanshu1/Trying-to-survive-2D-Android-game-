using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScript : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public void bgrunStart()
    {
        rb.velocity = transform.right * -1.2f;
    }
    void Update()
    {
        if (rb.position.x <= -24.5f)
        {
            rb.position = new Vector2(24.5f, rb.position.y);
        }
    }
}
