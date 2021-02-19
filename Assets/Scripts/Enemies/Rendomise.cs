using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rendomise : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy;

    [SerializeField]
    private float _height;
    
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(Enemy, new Vector3(10, _height, 0), Quaternion.Euler(0, 0, Random.Range(0f, 0)));
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
}
