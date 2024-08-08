using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class animacaoLab : MonoBehaviour
{

    public string nomeAnimacao;
    public bool verificarAnimacao,verificarAnimacao2, verificarAnimacao3, verificarAnimacao4, verificarAnimacao5, verificarAnimacao6;
    public GameObject[] ambientes;
    public GameObject ambienteTotal;


    private animacaoLab animLab;

    public bool[] ddd;
   

  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(nomeAnimacao == "CoWork" && verificarAnimacao == false)
        {
            ambientes[0].SetActive(true);
            ambienteTotal.SetActive(false);
            verificarAnimacao = true;
        }else

        if (nomeAnimacao == "VideoMaker" && verificarAnimacao2 == false)
        {

            ambientes[1].SetActive(true);
            ambienteTotal.SetActive(false);



            verificarAnimacao2 = true;
        }else
        if (nomeAnimacao == "salaImpressao" && verificarAnimacao3 == false)
        {

            ambientes[2].SetActive(true);
            ambienteTotal.SetActive(false);


            verificarAnimacao3 = true;
        }
        else
        if (nomeAnimacao == "salaReuniao" && verificarAnimacao4 == false)
        {

            ambientes[3].SetActive(true);
            ambienteTotal.SetActive(false);

            verificarAnimacao4 = true;
        }
        else
        if (nomeAnimacao == "ferramentas" && verificarAnimacao5 == false)
        {
            ambientes[4].SetActive(true);
            ambienteTotal.SetActive(false);



            verificarAnimacao5 = true;
        }else
        if (nomeAnimacao == "SMART" && verificarAnimacao6 == false)
        {
            ambientes[5].SetActive(true);
            ambienteTotal.SetActive(false);


            verificarAnimacao6 = true;
        }
     

    }


  


}
