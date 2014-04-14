using UnityEngine;
using System.Collections;

public class Level3InstantiateEnemies : MonoBehaviour {

    public Rigidbody2D Cobra;
    public Rigidbody2D Enemy3;
    public Rigidbody2D Enemy2;
    public Rigidbody2D Witch;

    Rigidbody2D cobraInstance, enemy3Instance, enemy2Instance, witchInstance;

    void Start()
    {
            InvokeRepeating("EnemyInstantiator", 5, 10);
    }

    void EnemyInstantiator()
    {
        float x = Random.Range(-38.0f, 38.0f);
        float y = Random.Range(0.0f, 13.0f);
        cobraInstance = Instantiate(Cobra, new Vector3(x, y, 0), Quaternion.identity) as Rigidbody2D;

        x = Random.Range(-38.0f, 38.0f);
        y = Random.Range(0.0f, 13.0f);
        enemy2Instance = Instantiate(Enemy2, new Vector3(x, y, 0), Quaternion.identity) as Rigidbody2D;

        x = Random.Range(-38.0f, 38.0f);
        y = Random.Range(0.0f, 13.0f);
        enemy3Instance = Instantiate(Enemy3, new Vector3(x, y, 0), Quaternion.identity) as Rigidbody2D;

        x = Random.Range(-38.0f, 38.0f);
        y = Random.Range(0.0f, 13.0f);
        witchInstance = Instantiate(Witch, new Vector3(x, y, 0), Quaternion.identity) as Rigidbody2D;
    }

    void Update()
    {
        //Time.timeScale = 1; // comment this when build the game

    }
}
