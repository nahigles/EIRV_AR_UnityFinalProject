using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
    int dir = -1;
    private Transform _transform;
    int i = 5;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (i > 5)
        {
            _transform.Translate(new Vector3(0, speed * dir, 0) * Time.deltaTime);
            i = 0;
            dir = -dir;

        }
        i++;

    }
}
