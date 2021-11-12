using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDown : MonoBehaviour
{
    public float twitterCoolDownTime = 300;
    float nextActivateTime = 0;
    public bool hasClickedTwitter = false;
    
    private void Update(){
        if (Time.time > nextActivateTime){
            if(hasClickedTwitter==true){
            nextActivateTime = Time.time + twitterCoolDownTime;
            }
        }
    }
}
