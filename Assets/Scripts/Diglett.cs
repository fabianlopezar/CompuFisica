using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diglett : MonoBehaviour
{
    public Animator animator;
    public float time = 0;
    void Start()
    {
        time = 3;
    }
  
    void Update()
    {
        time = time - Time.deltaTime;
        if (time <= 0)
        {
            Mostrar();
            time = 3;
            Esconder();
        }
    }
    void Mostrar()
    {
        Debug.Log("Mostrar");
        animator.Play("animMostrarTopo");
    }
    void Esconder()
    {
        Debug.Log("Esconder");
        animator.Play("animEsconderTopo");
    }
    void Esperar()
    {
        animator.Play("animEsperarTopo");
        Debug.Log("Esperar");
    }
    void AnimarGolpe()
    {
        Debug.Log("AnimarGolpe");
    }
    void SumarPunto()
    {
        Debug.Log("SumarPunto");
    }
}
