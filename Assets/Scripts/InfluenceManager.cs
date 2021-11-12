using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfluenceManager : MonoBehaviour
{
    public Player player;
    public Button twitterButton;
    public Button twitchButton;
    public Button twitchSpeedUp;
    public Button youtubeButton;
    float twitterCoolDownTime = 180f;
    float remainingTwitter = 180f;
    float twitchCoolDownTime = 600f;
    float remainingTwitch = 600f;
    float streamTime = 720f;
    float youtubeCoolDownTime = 600f;
    float remainingYoutube = 600f;
    public Text twitchCooldownTime;
    public Text twitterCooldownTime;
    public Text youtubeCooldownTime;
    public void ClickedTwitter(){
        StartCoroutine(ActivateTwitter());
    }
    public void ClickedTwitch(){
        StartCoroutine(ActivateTwitch());
    }
    public void ClickedYoutube(){
        StartCoroutine(ActivateYoutube());
    }
    public void SpeedUp(){
        streamTime-=0.2f;
        player.AddInfluence(2);
    }
    IEnumerator ActivateTwitter(){
        player.AddInfluence(1000);
        while(remainingTwitter>0f){
            twitterCooldownTime.gameObject.SetActive(true);
            twitterButton.interactable = false;
            twitterCooldownTime.text = remainingTwitter.ToString() + "s";
            yield return new WaitForSeconds(1);
            remainingTwitter--;
        }
        twitterButton.interactable = true;
        twitterCooldownTime.gameObject.SetActive(false);
        remainingTwitter = twitterCoolDownTime;
        player.SavePlayer();
    }
    IEnumerator ActivateTwitch(){
        while(streamTime>0f){
            player.AddInfluence(10);
            twitchButton.interactable = false;
            twitchSpeedUp.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            streamTime--;
        }
        streamTime = 720f;
        while(remainingTwitch>0f){
            twitchButton.interactable = false;
            twitchCooldownTime.text = remainingTwitch.ToString() + "s";
            yield return new WaitForSeconds(1);
            remainingTwitch--;
        }
        player.AddMoney(500);
        twitchButton.interactable = true;
        twitchCooldownTime.gameObject.SetActive(false);
        remainingTwitch = twitchCoolDownTime;
        player.SavePlayer();
    }
    IEnumerator ActivateYoutube(){
        player.AddInfluence(player.influencePoints/10);
        while(remainingYoutube>0f){
            youtubeCooldownTime.gameObject.SetActive(true);
            youtubeButton.interactable = false;
            youtubeCooldownTime.text = remainingYoutube.ToString() + "s";
            yield return new WaitForSeconds(1);
            remainingYoutube--;
        }
        player.AddMoney(250);
        youtubeButton.interactable = true;
        youtubeCooldownTime.gameObject.SetActive(false);
        remainingYoutube = youtubeCoolDownTime;
        player.SavePlayer();
    }
}
