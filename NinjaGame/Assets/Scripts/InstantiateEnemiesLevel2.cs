using UnityEngine;
using System.Collections;

public class InstantiateEnemiesLevel2 : MonoBehaviour {

    public Rigidbody2D Cobra;
    public Rigidbody2D Enemy3;
    bool instantiateEnemy = true;

    void Update()
    {
        //Time.timeScale = 1;
        Rigidbody2D cobraInstance, enemy3Instance;
        if (instantiateEnemy)
        {
            cobraInstance = Instantiate(Cobra, new Vector3(9, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
            enemy3Instance = Instantiate(Enemy3, new Vector3(16, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
            //enemy3Instance = Instantiate(Enemy3, new Vector3(8, -0.5f, 0), Quaternion.identity) as Rigidbody2D;
            instantiateEnemy = false;
        }
    }
}
