using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    protected override void WriteMessage() // POLYMORPHISM
    {
        base.WriteMessage();
        Debug.Log("I'm also a sphere");
    }
}
