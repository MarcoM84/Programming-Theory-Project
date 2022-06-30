using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string message { get; protected set; } // ENCAPSULATION

    private void Start()
    {
        message = "I am a shape";
    }

    protected void OnMouseDown()
    {
        WriteMessage(); // ABSTRACTION
    }

    protected virtual void WriteMessage()
    {
        Debug.Log(message);
    }
    protected virtual void WriteMessage(string text)  // POLYMORPHISM
    {
        Debug.Log(text);
    }
}
