using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject Meteor;
    public GameObject UFO;

    float spawnTime = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0 ) {
            var pos = transform.position;
            pos.x = Random.Range(-8.0f, 8.0f);


          var dice = Random.Range(0, 5);
            if (dice == 0)
            {
                var m = Instantiate(UFO, pos, Quaternion.identity); //No Rotation
                Destroy(m, 7);
            }
            else
            {
                var m = Instantiate(Meteor, pos, Quaternion.identity); //No Rotation
                var scale = Random.Range(1.0f, 3.0f);
                Destroy(m, 7);
            }
            spawnTime = 0.5f;
        }
    }
}
