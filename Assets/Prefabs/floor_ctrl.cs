using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3 (Random.Range (5.0f, 10.0f), Random.Range (-3.0f, 1.0f), 0.0f);
    }
}
