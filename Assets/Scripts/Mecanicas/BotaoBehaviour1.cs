﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoBehaviour1 : MonoBehaviour
{
    public Animator porta;
    public Animator senha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        porta.SetBool("Aberto", true);
        senha.SetBool("aberto", true);
        GetComponent<Animator>().SetBool("Pressionado", true);
    }

}
