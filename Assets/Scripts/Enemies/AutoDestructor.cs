using UnityEngine;

public class AutoDestructor : MonoBehaviour
{
    [SerializeField]
    private float _destroyTime;

    private void Start()
    {
        Destroy(gameObject, _destroyTime);
    }
}