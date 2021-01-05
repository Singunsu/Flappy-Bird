using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gob : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.left * 5 * Time.deltaTime;
    }
}
