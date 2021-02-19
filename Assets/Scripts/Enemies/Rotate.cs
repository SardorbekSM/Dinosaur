using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float rotate = 0;
    // Update is called once per frame
    void Update()
    {
        rotate += Time.fixedDeltaTime * 100;
        transform.Rotate(0,0, rotate);        
    }
}
