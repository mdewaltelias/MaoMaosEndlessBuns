
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject coin;
    public GameObject enemy;
    public GameObject boss;
    float spawnTime = 2.0f;

    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
        {
            var dice = Random.Range(0, 5);
            if (dice ==0)
            {
                Instantiate(boss, transform.position, transform.rotation);


            }
            else if (dice == 1 || dice ==2)
            {
                var pos = transform.position;
                pos.y = Random.Range(-4,3);
                Instantiate(coin, pos, transform.rotation);
            }
            else
            {
                Instantiate(enemy, transform.position, transform.rotation);
            }
            spawnTime = Random.Range(1.5f, 3.0f);
                
     
            }
        }
    }
  
