using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarefa4 : MonoBehaviour
{
    public float speed;
    int valor = 0;
    public List<GameObject> pontos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pontos[valor].transform.position, 3f * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            {
            novoponto();
            }
    }
    public void novoponto()
    {
        valor++;
        if(valor>=pontos.Count)
            {
            valor = 0;
            }
    }
}
