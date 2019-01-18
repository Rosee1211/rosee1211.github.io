using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolSetter: MonoBehaviour
{
    
    public bool state;

    public void ToggleBool()
    {
        state = !state;
    }

    public void Reset()
    {
        state = false;
    }
}
