using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    protected override void WriteMessage() // POLYMORPHISM
    {
        base.WriteMessage();
        Debug.Log("I'm also a cube");
    }
}
