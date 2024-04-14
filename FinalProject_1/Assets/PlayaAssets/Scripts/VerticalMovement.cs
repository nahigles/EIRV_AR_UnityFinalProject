using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    int myTime = 1;
    int dir = -1;
    private Transform _transform;
    float acum = 0;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (acum > myTime)
        {
            acum = 0;
            dir = -dir;

        }

        Vector3 myVec = new Vector3(0.0f, speed * dir, 0.0f);
        _transform.Translate(myVec.normalized * Time.deltaTime*0.02f);
        acum += Time.deltaTime;
    }
}
