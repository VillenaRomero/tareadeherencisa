using System;
using UnityEngine;

public class stadistic : MonoBehaviour
{
    private string name;
    private int atack;
    private int mana;

    public stadistic(string name, int atack, int mana)
    {
        this.name = name;
        this.atack = atack;
        this.mana = mana;
    }
    public void habilidad1() {
        print("habilidad de fuego");
    }
    public void habilidad2() {
        print("uso canto de hielo");
    }
}
