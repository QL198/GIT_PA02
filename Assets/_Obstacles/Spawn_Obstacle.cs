using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Obstacle : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float positionx;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjects()
    {
        int Randomint = Random.Range(0, SpawnObject.Length);
        positionx = Random.Range(-1, 1.21f);
        transform.position = new Vector3(positionx, transform.position.y, transform.position.z);
        Instantiate(SpawnObject[Randomint], transform.position, transform.rotation);
    }
}
