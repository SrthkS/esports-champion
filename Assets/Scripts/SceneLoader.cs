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
<<<<<<< HEAD
    [SerializeField] public Player player;
=======
    public Player player;
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
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
<<<<<<< HEAD
        StartCoroutine(LoadScreen("Quick_Shot 1"));
=======
        StartCoroutine(LoadScreen("Quick Shot"));
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
    }
    public void LoadPrecisionShot(){
        StartCoroutine(LoadScreen("Precision Shot"));
    }
<<<<<<< HEAD
=======
    public void LoadStrafeShot(){
        StartCoroutine(LoadScreen("Strafe Shot"));
    }
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
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
