using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transitionL;
    public Animator transitionR;
    public Animator transitionTL;
    public void LoadStartMenu(){
        StartCoroutine(LoadScreen("Start Menu"));
    }
    public void LoadMainScreen(){
        StartCoroutine(LoadScreen("Main Screen"));
    }
    public void LoadCredits(){
        StartCoroutine(LoadScreen("Credits"));
    }
    public void LoadFinalScreen(){
        StartCoroutine(LoadScreen("Final Screen"));
    }
    public void LoadQuickShot(){
        StartCoroutine(LoadScreen("Quick Shot"));
    }
    public void LoadPrecisionShot(){
        StartCoroutine(LoadScreen("Precision Shot"));
    }
    public void LoadStrafeShot(){
        StartCoroutine(LoadScreen("Strafe Shot"));
    }
    public void LoadTwitch(){
        StartCoroutine(LoadScreen("Twitch"));
    }
    public void LoadYouTube(){
        StartCoroutine(LoadScreen("YouTube"));
    }
    public void LoadTwitter(){
        StartCoroutine(LoadScreen("Twitter"));
    }
    public void LoadCityTourney(){
        StartCoroutine(LoadScreen("City Tourney"));
    }
    public void LoadStateTourney(){
        StartCoroutine(LoadScreen("State Tourney"));
    }
    public void LoadNationalTourney(){
        StartCoroutine(LoadScreen("National Tourney"));
    }
    IEnumerator LoadScreen(string SceneName){
        transitionL.SetTrigger("Start");
        transitionR.SetTrigger("Start");
        transitionTL.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneName);
    }
}
