using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rendomise : Movement
{
    [SerializeField]
    private GameObject Enemy;
    
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(Enemy, new Vector3(10, -3, 0), Quaternion.Euler(0, 0, Random.Range(0f, 0)));
            yield return new WaitForSeconds(Random.Range(3f, 5f));
        }

    }
}
