using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float _rotate = 0;
    // Update is called once per frame
    private void FixedUpdate()
    {
        _rotate += Time.deltaTime * 100;
        transform.Rotate(0,0, _rotate);        
    }
}
