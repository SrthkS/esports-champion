
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //starts before first frame

    void Start()
    {
<<<<<<< HEAD
        if(GameControl.playerLives<=0){
            Destroy(gameObject);
        }
=======
        
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        Destroy(gameObject, 1f);
        GameControl.userMiss = 1;
    }

    private void OnMouseDown(){
        //score plus 100
        GameControl.score += 100;
        //increment targets hits
        GameControl.targetsHit +=1;
        Destroy(gameObject);
        //work
        GameControl.userMiss = 0;

    }



}