using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScript2 : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void bgrunStart2()
    {
        rb.velocity = transform.right * -2.5f;
    }
    // Update is called once per frame
    void Update()
    {

        if (rb.position.x <= -24.5f)
        {
            rb.position = new Vector2(24.5f, rb.position.y);
        }

    }
}
