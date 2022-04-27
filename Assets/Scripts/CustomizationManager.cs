using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Customization
{
    public int headIndex;
    public int bodyIndex;
    public int feetIndex;
}

public class CustomizationManager : MonoBehaviour
{
    
    // Internals
    private JSONHelper jsonHelper;
    
    #region CRUD

    public void CreateCustomization()
    {
        
    }

    public void ReadCustomization()
    {
        
    }

    public void UpdateCustomization()
    {
        
    }

    public void DeleteCustomization()
    {
        
    }

    #endregion

    #region Unity Methods

    private void Start()
    {
        jsonHelper = JSONHelper.instance;
    }

    #endregion
}
