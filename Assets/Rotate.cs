using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rot = transform.eulerAngles;
        rot.y += 50f * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rot);
    }
}
