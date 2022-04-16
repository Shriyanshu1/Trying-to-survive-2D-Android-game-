using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public Rigidbody2D bull;
    
    
    // Start is called before the first frame update
    void Start()
    {
        bull = GetComponent<Rigidbody2D>();
        bull.velocity = transform.right * 15;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bull.position.x > 30f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Hazard")
        {
            
            Destroy(gameObject);
        }
    }
}
