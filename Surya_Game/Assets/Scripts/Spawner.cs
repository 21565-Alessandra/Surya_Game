using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] skyObjects;
    public GameObject meteor;

    public float xBounds, yBound;

        void Start()
    {
        StartCoroutine(SpawnRandomGameObject());    
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomObject = Random.Range(0, skyObjects.Length);

        if(Random.value <= .6f)
            Instantiate(skyObjects[randomObject],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        else Instantiate(meteor,
            new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        
        StartCoroutine(SpawnRandomGameObject());

    }

    
}
