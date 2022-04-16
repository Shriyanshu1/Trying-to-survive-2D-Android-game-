using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class copterScript : MonoBehaviour
{
   // public Rigidbody2D copter;
    public Transform copterPos;
    public GameObject blast;
    public UIcontroller obj;
    public fuelButton obj2;
    public fireButton obj3;
    public AudioSource fuel;
    public AudioSource ammo;
    public UIcontroller obj4;
    // Start is called before the first frame update
    void Start()
    {
       
       
        copterPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Hazard")
        {
            
            Instantiate(blast, copterPos.position, copterPos.rotation);
            
            obj.gameOver = true;
            obj4.blast();
           Destroy(gameObject);
            
        }
        if(collision.collider.tag == "FuelTank")
        {
            obj2.fuelcount += 40;
            fuel.Play();
        }
        if (collision.collider.tag == "Ammo")
        {
            obj3.bulletCount += 20;
            ammo.Play();
        }
    }
}
