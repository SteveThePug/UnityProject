using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Vector3 pos(string tag)
    {
        return GameObject.FindGameObjectWithTag(tag).transform.position;
    }

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3 (0,2,-4) + pos("Player");
    }
}
