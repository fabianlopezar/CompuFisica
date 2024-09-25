using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//video 10 https://www.youtube.com/watch?v=heXze1q5OBA&list=PLJMnJZL7OKtHQkrqG7oL-1o48kXA0YBgV&index=10

public class ControlPersonaje : MonoBehaviour
{
    public GameObject[] topos;
    public int randomValue=0;

    void Start()
    {
        //randomValue = Random.Range(0, 8);
        //randomValue = 5;
        StartCoroutine("lanzarTopo");
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator lanzarTopo()
    {
        topos[randomValue].GetComponent<Diglett>().Mostrar();
        yield return new WaitForSeconds(1);
        topos[randomValue].GetComponent<Diglett>().Esconder();
        yield return new WaitForSeconds(1);
       
       // randomValue = Random.Range(0, 8);
        StartCoroutine("lanzarTopo");
        
    }
}
