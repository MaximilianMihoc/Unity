using UnityEngine;
using System.Collections;

public class InstantiateEnemiesLevel1 : MonoBehaviour 
{

    public Rigidbody2D Cobra;
    public Rigidbody2D Enemy3;
    bool instantiateEnemy = true;

	void Update () 
    {
        Rigidbody2D cobraInstance, enemy3Instance;
        if (instantiateEnemy)
        {
            cobraInstance = Instantiate(Cobra, new Vector3(40, 0, 0), Quaternion.identity) as Rigidbody2D;
            enemy3Instance = Instantiate(Enemy3, new Vector3(113, -19, 0), Quaternion.identity) as Rigidbody2D;
            instantiateEnemy = false;
        }
	}
}
