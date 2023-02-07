using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieSpawner : MonoBehaviour
{
    public GameObject VegPrefab;
    public Transform[] SpawnLocs;

    public float minDelay = .1f;
    public float maxDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, SpawnLocs.Length);
            Transform spawnLoc = SpawnLocs[spawnIndex];

            GameObject spawnedVeggie = Instantiate(VegPrefab, spawnLoc.position, spawnLoc.rotation);
            Destroy(spawnedVeggie, 5f);
        }
    }
}
