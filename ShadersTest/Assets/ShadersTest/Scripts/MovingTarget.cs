using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float speed;
    public int dir;
    [SerializeField] private float dist;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(dir,0,0) * speed * Time.deltaTime, Space.World);

        dist = Vector3.Distance(new Vector3(dir * 2, 1.641f, 1), transform.position);

        if (dist <= 0.1)
        {
            dir = -dir;
            dist = 0;
        }
    }
}
