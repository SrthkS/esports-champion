using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int influencePoints = 0;
    public int skillPoints = 0;
    public int money = 0;
    public Text skillText;

    public void Update(){
        skillText.text = skillPoints.ToString();
    }
    public void AddInfluence(int influenceGain){
        influencePoints+=influenceGain;
    }
    public void AddSkill(int skillGain){
        skillPoints+=skillGain;
    }
    public void AddMoney(int moneyGain){
        money+=moneyGain;
    }

    public void SavePlayer(){
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer(){
        PlayerData data = SaveSystem.LoadData();
        influencePoints = data.influencePoints;
        skillPoints = data.skillPoints;
        money = data.money;
    }
}
