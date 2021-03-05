using UnityEngine;

public class ByXPositionRepeater : MonoBehaviour
{
    private float _size;

    private void Start()
    {
        _size = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        Repeat();
    }

    private void Repeat()
    {
        transform.position = new Vector3(Mathf.Repeat(transform.position.x, _size), transform.position.y, transform.position.z);
    }
}
