using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScript : MonoBehaviour
{
    public Rigidbody2D item;
    public BoxCollider2D itemcollider;
    // Start is called before the first frame update
    void Start()
    {
        item = GetComponent<Rigidbody2D>();
        item.velocity = transform.right * -8f;
        
    }

    // Update is called once per frame
    void Update()
    {
       if(item.position.x < -25)
        {
            Destroy(gameObject);
        }
        if (item.position.x < -5)
        {
            itemcollider = GetComponent<BoxCollider2D>();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
