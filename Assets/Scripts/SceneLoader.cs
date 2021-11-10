using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transitionL;
    public Animator transitionR;
    public Animator transitionTL;
    public Animator trainingMenuLoader;
    public Animator influenceMenuLoader;
    public Player player;
    public GameObject saveFailPopup;
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
    public void LoadTourneys(){
        StartCoroutine(LoadScreen("Tourneys"));
    }
    public void QuitGame(){
        Application.Quit();
    }
    public void ResetGame(){
        player.skillPoints = 0;
        player.influencePoints = 0;
        player.money = 0;
    }
    public void LoadTrainingMenu(){
        trainingMenuLoader.SetTrigger("LoadTraining");
    }
    public void CloseTrainingMenu(){
        trainingMenuLoader.SetTrigger("CloseTraining");
    }
    public void LoadInfluenceMenu(){
        influenceMenuLoader.SetTrigger("LoadInfluence");
    }
    public void CloseInfluenceMenu(){
        influenceMenuLoader.SetTrigger("CloseInfluence");
    }
    public void PopupSaveFail(){
        saveFailPopup.SetActive(true);
    }
    public void CloseSaveFail(){
        saveFailPopup.SetActive(false);
    }
    IEnumerator LoadScreen(string SceneName){
        transitionL.SetTrigger("Start");
        transitionR.SetTrigger("Start");
        transitionTL.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneName);
    }
}
