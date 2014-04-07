using UnityEngine;
using System.Collections;

public class DestroyWitchFire : MonoBehaviour {

	void Start()
    {
        Destroy(gameObject, 0.5f);
    }
}
