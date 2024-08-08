using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao3 : MonoBehaviour
{
    private bool isVerificarToque;

    private animacaoLab anim;

    public GameObject obj;
    public GameObject total;
    public bool dddd;
    // Start is called before the first frame update
    void Start()
    {
        anim = FindObjectOfType(typeof(animacaoLab)) as animacaoLab;

    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                if (anim.ddd[3] == false)
                {
                  
                    obj.SetActive(false);
                    total.SetActive(true);
                    anim.ddd[3] = true;
                }
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
