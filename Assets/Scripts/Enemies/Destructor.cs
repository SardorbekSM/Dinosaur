using UnityEngine;

public class Destructor : MonoBehaviour
{
    [SerializeField]
    private float _destroyTime;

    private void Start()
    {
        Destroy(gameObject, _destroyTime);
    }
}