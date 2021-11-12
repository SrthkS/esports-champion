using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

private static DontDestroy instance = null;
    private void Awake()
        {
            if (instance == null)
            { 
                instance = this;
                DontDestroyOnLoad(gameObject);
                return;
            }
            if (instance == this) return; 
            Destroy(gameObject);
        }
    }
