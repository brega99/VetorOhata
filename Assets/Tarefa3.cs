using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarefa3 : MonoBehaviour
{
    public GameObject Play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Play.transform.position, 3f * Time.deltaTime);
    }
}
