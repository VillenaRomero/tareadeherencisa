using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    /*baseenemi simpleenemi = new baseenemi();
    baseobject simpleiitem = new baseobject();

    List<baseobject> drop = ;*/

    enemi1 enemigo1 = new("julio",10,20);
    enemi2 enemigo2 = new("david",20,40);

    private void Start()
    {
       // Console.WriteLine("el enemigo se llama " + enemigo1.name);
        enemigo1.habilidad1();
        //Console.WriteLine("el enemigo se llama " + enemigo2.name);
        enemigo2.habilidad2();
    }
}
