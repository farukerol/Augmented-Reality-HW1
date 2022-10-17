using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public void changeScene(string s)
    {
        Application.LoadLevel (s);
    }
    
}
