using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startCount : MonoBehaviour
{
    public Text startCountText;
    public int count = 3;
    public bgScript obj1;
    public bgScript2 obj2;
    public bgScript obj3;
    public bgScript2 obj4;
    public scoreScript obj5;
    public jetSpawner obj6;
    public Rigidbody2D copter;
    public fuelButton obj7;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        count = 3;
        StartCoroutine(countFunc());
        copter.gravityScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        startCountText.text = count.ToString();
        if (count < 0)
        {
            gameObject.SetActive(false);
            obj1.bgrunStart();
            obj2.bgrunStart2();
            obj3.bgrunStart();
            obj4.bgrunStart2();
            obj5.startScorecount();
            obj6.startSpawning();
            copter.gravityScale = 0.2f;
            obj7.gamestart = true;
            
        }
      
    }

    IEnumerator countFunc()
    {
        yield return new WaitForSeconds(1);
        count--;
        if (count >= 0)
        {
            StartCoroutine(countFunc());
        }
        
    }
}
