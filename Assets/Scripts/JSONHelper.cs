using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONHelper : MonoBehaviour
{
    public static JSONHelper instance;
    
    // Consts
    
    
    // Externals
    
    
    // Internals
    
        
    public void ImportMascot()
    {
        
    }

    public void ExportMascot()
    {
        
    }

    private void SingletonCheck()
    {
        if (!JSONHelper.instance)
        {
            Debug.Log(this.name + " initiated as singleton.");
            JSONHelper.instance = instance;
        }
        else
        {
            Debug.Log("Another JSONHelper found. Destroying this one.");
            Destroy(this);
        }
    }

    #region Unity Methods

    private void Awake()
    {
        SingletonCheck();
    }

    #endregion
}
