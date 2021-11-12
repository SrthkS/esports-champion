using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int influencePoints;
    public int skillPoints;
    public int money;

    public PlayerData (Player player){
        influencePoints = player.influencePoints;
        skillPoints = player.skillPoints;
        money = player.money;
    }
}
