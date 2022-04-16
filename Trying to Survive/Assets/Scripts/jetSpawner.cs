using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetSpawner : MonoBehaviour
{
    public GameObject jetPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startSpawning()
    {
        StartCoroutine(spawnJet());    }

    IEnumerator spawnJet()
    {
        yield return new WaitForSeconds(Random.Range(1.5f, 2.5f));
        Instantiate(jetPrefab, new Vector2(20f, Random.Range(4f, 0f)),Quaternion.identity);
        StartCoroutine(spawnJet());
    }
}
