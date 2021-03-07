using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float or = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector2 input = new Vector2(or, ver);
        transform.Translate(input.x * Time.deltaTime * speed, 0, input.y*Time.deltaTime*speed);

    }
}
