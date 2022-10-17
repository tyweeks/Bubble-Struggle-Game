using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public static bool IsFired;
    public float speed = 2;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        IsFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IsFired = true;
        }

        if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1, 0, 1);
        }
    }
}
