using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacaoObjeto : MonoBehaviour
{
    private bool isVerificarToque;
  
    public string nomeAnimacao;
    private animacaoLab _animacaoLab;
    public bool dddd;
    
    // Start is called before the first frame update
    void Start()
    {
        
        _animacaoLab = FindObjectOfType(typeof(animacaoLab)) as animacaoLab;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                if (dddd == false)
                {
                    _animacaoLab.nomeAnimacao = nomeAnimacao;
                    dddd = true;
                }
                
               // anim.enabled = true;
             
            }
        }
    }

    private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }
}
