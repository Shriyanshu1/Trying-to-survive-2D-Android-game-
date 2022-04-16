using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fireButton : MonoBehaviour
{
    public Text bullets;
    public int bulletCount;
    public GameObject bulletPrefab;
    public Transform firepoint;
    public AudioSource shoot;
    // Start is called before the first frame update
    void Start()
    {
        bulletCount = 30;
    }

    // Update is called once per frame
    void Update()
    {
        bullets.text = bulletCount.ToString();
    }

    public void fire()
    {
        {
            if (bulletCount > 0)
            {
                
                bulletCount--;
                Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
                shoot.Play();
            }

        }
    }
}
