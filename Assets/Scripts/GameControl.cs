using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Player player;

    [SerializeField]
    private GameObject target;

    [SerializeField]
    private Texture2D cursorTexture;

    private Vector2 cursorHotspot;

    private Vector2 mousePos;

    [SerializeField]

    private Text getReadyText;

    [SerializeField]

    private Text playerLivesText;

    [SerializeField]

    private GameObject resultsPanel;

    [SerializeField]

    private Text scoreText, targetsHitText, shotsFiredText, accuracyText;

    public static int score, targetsHit, playerLives, targetsAmount, userMiss;


    private float shotsFired;

    private float accuracy;

    //private int targetsAmount;

    private Vector2 targetRandomPosition;

    void Start(){

        cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height /2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);

        

        getReadyText.gameObject.SetActive(false);

        //initialize vars
        targetsAmount = 50;
        score = 0;
        shotsFired = 0;
        targetsHit = 0;
        accuracy = 0f;
        



    }
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            shotsFired += 1f;

        }


    }

    private IEnumerator GetReady(){
        for(int i= 3; i>0; i--){
            getReadyText.text = "Ready?\n" + i.ToString();
            yield return new WaitForSeconds(1f);


        }
        getReadyText.text = "Go!";
        yield return new WaitForSeconds(1f);

        StartCoroutine("SpawnTargets");


    }

    private IEnumerator SpawnTargets(){

        getReadyText.gameObject.SetActive(false);
        
        score=0;
        shotsFired=-3;
        targetsHit=0;
        accuracy=0;
        playerLives=3;

        playerLivesText.gameObject.SetActive(true);
        playerLivesText.text = "Lives: " + playerLives.ToString();

        for(int i = targetsAmount; i>0; i--){
            targetRandomPosition = new Vector2(Random.Range(-7f,7f), Random.Range(-4f,4f));
            Instantiate(target, targetRandomPosition, Quaternion.identity);

            yield return new WaitForSeconds(0.7f);
            if(userMiss==1){
                playerLives--;
                shotsFired++;
                playerLivesText.text = "Lives: " + playerLives.ToString();
            }
            if(playerLives<=0){
                break;
            }  

        }

        resultsPanel.SetActive(true);
        scoreText.text = "Score: " + score;
        targetsHitText.text = "Targets Hit: " + targetsHit + "/" + targetsAmount;
        shotsFiredText.text = "Shots Fired: " + shotsFired;
        accuracy = (float)targetsHit/(float)shotsFired * 100f;
        accuracyText.text = "Accuracy: " + accuracy.ToString("N2") + "%";
        player.AddSkill((int)(score*accuracy/1000));
        player.SavePlayer();



    }
    public void StartGetReadyCoroutine(){

        resultsPanel.SetActive(false);
        getReadyText.gameObject.SetActive(true);
        StartCoroutine("GetReady");


    }    


}