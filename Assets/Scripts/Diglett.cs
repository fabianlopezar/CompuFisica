using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diglett : MonoBehaviour
{
    public Animator animator;
    public float time = 0;
   
  
    void Update()
    {
        
    }
    public void Mostrar()
    {
        Debug.Log("Mostrar");
        animator.Play("animMostrarTopo");
    }
    public void Esconder()
    {
        Debug.Log("Esconder");
        animator.Play("animEsconderTopo");
    }
    public void Esperar()
    {
        animator.Play("animEsperarTopo");
        Debug.Log("Esperar");
    }
    public void AnimarGolpe()
    {
        Debug.Log("AnimarGolpe");
    }
    public void SumarPunto()
    {
        Debug.Log("SumarPunto");
    }
}
