using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    private animacaoLab lab;

    private interacao inter;
    private interacao1 inter1;
    private interacao2 inter2;
    private interacao3 inter3;  
    private interacao4 inter4;
        private interacao5 inter5;


    private void Start()
    {
        lab = FindObjectOfType(typeof(animacaoLab)) as animacaoLab;
        inter = FindObjectOfType(typeof(interacao)) as interacao;
        inter1 = FindObjectOfType(typeof (interacao1)) as interacao1;
        inter2 = FindObjectOfType(typeof (interacao2)) as interacao2;
        inter3 = FindObjectOfType(typeof(interacao3)) as interacao3;
        inter4 = FindObjectOfType(typeof(interacao4)) as interacao4;
        inter5 = FindObjectOfType(typeof(interacao5)) as interacao5;
    }
    public void iniciarJogo()
    {
        SceneManager.LoadScene("MONTAGEM");
    }

    public void sairJogo()
    {
       Application.Quit();
    }


    public void reiniciarJogo()
    {
        lab.verificarAnimacao = false;
        lab.verificarAnimacao2 = false;
        lab.verificarAnimacao3 = false;
        lab.verificarAnimacao4 = false;
        lab.verificarAnimacao5 = false;
        lab.verificarAnimacao6 = false;

        lab.nomeAnimacao = " ";
        lab.ddd[0] = false;
        lab.ddd[1] = false;
        lab.ddd[2] = false;
        lab.ddd[3] = false;
        lab.ddd[4] = false;
        lab.ddd[5] = false;
        
    }

}
