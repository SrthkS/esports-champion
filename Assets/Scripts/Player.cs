using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
[System.Serializable]
=======
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
public class Player : MonoBehaviour
{
    public int influencePoints = 0;
    public int skillPoints = 0;
    public int money = 0;
    public Text skillText;
<<<<<<< HEAD
    public Text influenceText;
    public Text moneyText;
    public int nationalWins = 0;
    public SceneLoader sceneLoader;

    public void Update(){
        skillText.text = skillPoints.ToString();
        influenceText.text = influencePoints.ToString();
        moneyText.text = money.ToString();
        if ((influencePoints>=1000000) & (skillPoints>=10000) & (nationalWins>=3)){
            sceneLoader.LoadFinalScreen();
        }
=======

    public void Update(){
        skillText.text = skillPoints.ToString();
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
    }
    public void AddInfluence(int influenceGain){
        influencePoints+=influenceGain;
    }
    public void AddSkill(int skillGain){
        skillPoints+=skillGain;
<<<<<<< HEAD
        Debug.Log(skillPoints);
=======
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
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
