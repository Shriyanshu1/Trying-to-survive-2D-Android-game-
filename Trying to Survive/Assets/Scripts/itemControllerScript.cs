using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemControllerScript : MonoBehaviour
{
    public GameObject fuel;
    public GameObject Ammunation;
    public UIcontroller obj;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnFuel());
        StartCoroutine(spawnAmmu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     IEnumerator spawnFuel()
    {
        yield return new WaitForSeconds(Random.Range(15, 25));
        if (obj.gameOver == false)
        {
            Instantiate(fuel, new Vector2(13, Random.Range(4, -2)), Quaternion.identity);
            StartCoroutine(spawnFuel());
        }
    }
    IEnumerator spawnAmmu()
    {
        yield return new WaitForSeconds(Random.Range(25, 30));
        if (obj.gameOver == false)
        {
            Instantiate(Ammunation, new Vector2(13, Random.Range(4, -2)), Quaternion.identity);
            StartCoroutine(spawnAmmu());
        }
    }
}
