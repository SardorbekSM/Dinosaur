using UnityEngine;

public class ByZTransformRotator : MonoBehaviour
{
    private float _rotate = 0;

    [SerializeField]
    private int _calcAccuracy = 100;
    // Update is called once per frame
    private void FixedUpdate()
    {
        _rotate += Time.deltaTime * _calcAccuracy;
        transform.Rotate(0,0, _rotate);        
    }
}
