
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //starts before first frame

    void Start()
    {
        Destroy(gameObject, 1f);
    }

    private void OnMouseDown(){
        //score plus 100
        GameControl.score += 100;
        //increment targets hits
        GameControl.targetsHit +=1;
        Destroy(gameObject);

    }



}