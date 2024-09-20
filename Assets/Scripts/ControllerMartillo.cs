using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMartillo : MonoBehaviour
{
    public Animator animator;
    public Transform[] _positions;
    void Start()
    {
        
    }

    
    void Update()
    {
        //DetectarBoton();
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Golpear(0);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Golpear(1);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Golpear(2);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Golpear(3);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Golpear(4);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            Golpear(5);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Golpear(6);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            Golpear(7);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            Golpear(8);
        }
    }
    public void Golpear(int posicion)
    {
        Debug.Log("soy la posicion"+ posicion);
        transform.position = _positions[posicion].position;
        animator.Play("animMartilloGolpe");
        
    }
    public void DetectarBoton()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Golpear(0);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Golpear(1);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Golpear(2);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Golpear(3);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Golpear(4);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            Golpear(5);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Golpear(6);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            Golpear(7);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            Golpear(8);
        }

    }
}
