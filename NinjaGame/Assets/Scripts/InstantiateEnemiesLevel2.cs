using UnityEngine;
using System.Collections;

public class InstantiateEnemiesLevel2 : MonoBehaviour {

    public Rigidbody2D Cobra;
    public Rigidbody2D Enemy2;
    public Rigidbody2D Enemy3;
    Rigidbody2D cobraInstance, enemy3Instance, enemy2Instance;

    void Start()
    {
        cobraInstance = Instantiate(Cobra, new Vector3(9, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
        enemy3Instance = Instantiate(Enemy3, new Vector3(16, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
        enemy2Instance = Instantiate(Enemy2, new Vector3(40, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
        enemy3Instance = Instantiate(Enemy3, new Vector3(30, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
        enemy2Instance = Instantiate(Enemy2, new Vector3(50, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
        enemy3Instance = Instantiate(Enemy3, new Vector3(60, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
        enemy2Instance = Instantiate(Enemy2, new Vector3(70, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
    }

    void Update()
    {
        //Time.timeScale = 1;
    }
}
