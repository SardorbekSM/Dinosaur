using UnityEngine;

public class Destruction : Movement
{
    [SerializeField]
    private float _destroyTime;

    private void Start()
    {
        Destroy(gameObject, _destroyTime);
    }
}