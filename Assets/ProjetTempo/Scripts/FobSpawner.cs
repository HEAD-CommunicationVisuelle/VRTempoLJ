using UnityEngine;

public class FobSpawner : MonoBehaviour
{
    public GameObject fobPrefab;

    public float spawnInitialDelay = 2f;

    public float spawnDelay = 2f; // fobs every 2 seconds

    public float initialSpeed = 1f;

    public int fobCount = 20;

    public float verticalSpread = 1f;

    public float horizontalSpread = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        //spawn 10 fobs along the z axis
        for (int i = 0; i < fobCount; i++)
        {
            float distance = initialSpeed * spawnInitialDelay + i * initialSpeed / spawnDelay;
            Vector3 position = transform.position + new Vector3(0, 0, distance);

            // Créer un fobprefab à l'endroit du spawner
            GameObject fob = Instantiate(fobPrefab, position, Quaternion.identity);

            // look at the spawner
            fob.transform.LookAt(transform);

            // add a random offset to the position x and y
            fob.transform.position += new Vector3(Random.Range(-horizontalSpread/2, horizontalSpread/2), Random.Range(-verticalSpread/2, verticalSpread/2), 0);

            fob.GetComponent<Fob>().speed = initialSpeed;

        }
    }

}
