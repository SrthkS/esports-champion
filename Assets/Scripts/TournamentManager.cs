using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TournamentManager : MonoBehaviour
{
    public Player player;
    public Button city;
    public Button state;
    public Button national;
    public float winChance = 0;
    public Text cooldownTime;
    public Text decision;
    float remainingTime = 900f;

    private void Awake(){
        if(player.money<5000){
            national.interactable = false;
        }
        if(player.money<2000){
            state.interactable = false;
        }
        if(player.money<1000){
            city.interactable = false;
        }
    }
    public void CityClicked(){
        player.money -= 1000;
        winChance=player.skillPoints/10000;
        float choice=Random.Range(0f,1f);
        if (choice>=winChance){
            decision.text = "You won!";
            player.AddMoney(2000);
        }
        else{
            decision.text = "You lost...";
        }
        StartCoroutine(CoolDownTourney());
    }
    public void StateClicked(){
        player.money -= 2000;
        winChance=player.skillPoints*0.75f/10000;
        float choice=Random.Range(0f,1f);
        if (choice>=winChance){
            decision.text = "You Won!";
            player.AddMoney(4000);
        }
        else{
            decision.text = "You lost...";
        }
        StartCoroutine(CoolDownTourney());
    }
    public void NationalClicked(){
        player.money -= 5000;
        winChance=player.skillPoints*0.5f/10000;
        float choice=Random.Range(0f,1f);
        if (choice>=winChance){
            decision.text = "You won!";
            player.AddMoney(10000);
            player.nationalWins++;
        }
        else{
            decision.text = "You lost...";
        }
        StartCoroutine(CoolDownTourney());
    }
    IEnumerator CoolDownTourney(){
        while(remainingTime>0f){
            cooldownTime.gameObject.SetActive(true);
            cooldownTime.text = remainingTime.ToString() + "s";
            city.interactable = false;
            state.interactable = false;
            national.interactable = false;
            yield return new WaitForSeconds(1);
            remainingTime--;
        }
        cooldownTime.gameObject.SetActive(false);
        city.interactable = true;
        state.interactable = true;
        national.interactable = true;
        remainingTime = 900f;
    }
}
