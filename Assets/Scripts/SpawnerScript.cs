using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject [] alphabets;
    public float respawnTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AlphabetSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AlphabetSpawner() 
    { 
        while(true) {
            yield return new WaitForSeconds(respawnTime);
            SpawnAlphabet();
        }
    }
   
    void SpawnAlphabet() 
    {
      int randomValue = Random.Range(0, alphabets.Length);
      int randomX = Random.Range(-6, 6);
      Instantiate(alphabets[randomValue], new Vector2(randomX, transform.position.y), Quaternion.identity);
    }
}
