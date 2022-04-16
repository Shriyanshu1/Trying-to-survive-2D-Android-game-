using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetScript : MonoBehaviour
{
    public Rigidbody2D jet;
    public Transform jetPos;
    public GameObject destroyParticle;
    public UIcontroller obj;
    // Start is called before the first frame update
    void Start()
    {
        jet = GetComponent<Rigidbody2D>();
        jet.velocity = transform.right * -8f;
        GameObject destroyParticle = Instantiate(Resources.Load("destroyParticles", typeof(GameObject))) as GameObject;
        jetPos = GetComponent<Transform>();
        obj = GameObject.Find("UIcontroller").GetComponent<UIcontroller>();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (jet.position.x < -30f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "bullet")
        {

            obj.blast();
            Instantiate(destroyParticle, jetPos.position, jetPos.rotation);

            Destroy(gameObject);
        }
    }
}
