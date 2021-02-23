using System.Collections;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField]
    private GameObject _Enemy;

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
            Instantiate(_Enemy, new Vector3(10, _height, 0), Quaternion.Euler(0, 0, Random.Range(0f, 0)));
            yield return new WaitForSeconds(Random.Range(3f, 5f));
        }
    }
}
