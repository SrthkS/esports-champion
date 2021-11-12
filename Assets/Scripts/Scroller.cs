using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    Material background;
    public float offset;
    Vector2 offSet;

    void Awake()
    {
        background = GetComponent<Renderer>().material;
        offSet = new Vector2(offset,0);
    }
    void Update()
    {
        background.mainTextureOffset += offSet;
    }
}
