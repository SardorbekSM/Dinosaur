using UnityEngine;

public class Destruction : MonoBehaviour
{
    [SerializeField]
    private float _destroyTime;

    private void Start()
    {
        Destroy(gameObject, _destroyTime);
    }
}