using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float _rotate = 0;
    // Update is called once per frame
    private void FixedUpdate()
    {
        _rotate += Time.deltaTime * 100;
        transform.Rotate(0,0, _rotate);        
    }
}
