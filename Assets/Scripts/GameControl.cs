using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    //define vars and vectors needed for the game
    [SerializeField] public Player player;

    [SerializeField]
    private GameObject target;

    [SerializeField]
    private Texture2D cursorTexture;

    private Vector2 cursorHotspot;

    private Vector2 mousePos;

    [SerializeField]

    private Text readyText;

    [SerializeField]

    private Text playerLivesText;

    [SerializeField]

    private GameObject resultsPanel;

    [SerializeField]

    private Text scoreText, targetsHitText, shotsFiredText, accuracyText;

    public static int score, targetsHit, playerLives, targetsAmount, userMiss;


    private float shotsFired,shotsMissed;

    private float accuracy;

    //private int targetsAmount;

    private Vector2 targetRandomPosition;

    void Start(){
        //sets cursor to middle of screen
        cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height /2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);

        
        //ready text does not show
        readyText.gameObject.SetActive(false);

        //initialize vars
        targetsAmount = 1000;
        score = 0;
        shotsFired = 0;
        targetsHit = 0;
        accuracy = 0f;
        



    }
    void Update(){
        //increment shots fired by one everytime mouse is clicked
        if(Input.GetMouseButtonDown(0)){
            shotsFired += 1f;

        }


    }

    private IEnumerator GetReady(){
        //get read countdown for 3 seconds
        for(int i= 3; i>0; i--){
            readyText.text = "Ready?\n" + i.ToString();
            yield return new WaitForSeconds(1f);


        }
        //changes text to go 
        readyText.text = "Go!";
        yield return new WaitForSeconds(1f);
        //starts spawning targets
        StartCoroutine("SpawnTargets");


    }

    //spawn targets function
    private IEnumerator SpawnTargets(){
        //ready text is inactive
        readyText.gameObject.SetActive(false);
        //initalize resets vars after every run
        score=0;
        shotsFired=0;
        shotsMissed=0;
        targetsHit=0;
        accuracy=0;
        playerLives=3;

        //shows player lives count
        playerLivesText.gameObject.SetActive(true);
        playerLivesText.text = "Lives: " + playerLives.ToString();

        //will run the game until targets amount is gone
        for(int i = targetsAmount; i>0; i--){
            //randomizes target pos
            targetRandomPosition = new Vector2(Random.Range(-7f,7f), Random.Range(-4f,4f));
            Instantiate(target, targetRandomPosition, Quaternion.identity);

            yield return new WaitForSeconds(0.7f);
            //if user misses, playerlives decrements,increments shots missed and then updates player lives
            if(userMiss==1){
                playerLives--;
                shotsMissed++;
                playerLivesText.text = "Lives: " + playerLives.ToString();
            }
            //if player has no lives left, the game loop ends
            if(playerLives<=0){
                
                break;
            }
                
            

        }
        //displayes results panel
        //also calculates scores
        resultsPanel.SetActive(true);
        scoreText.text = "Score: " + score;
        targetsHitText.text = "Targets Hit: " + targetsHit + "/" + targetsAmount;
        shotsFiredText.text = "Shots Fired: " + shotsFired;
        accuracy = (float)targetsHit/(float)(shotsFired + shotsMissed) * 100f;
        accuracyText.text = "Accuracy: " + accuracy.ToString("N2") + "%";
        //saves score to skills points
        player.AddSkill((int)(score*accuracy/1000));
        player.SavePlayer();



    }
    //funct to start the game when the player clicks the "start training" button
    public void StartGetReadyCoroutine(){

        resultsPanel.SetActive(false);
        readyText.gameObject.SetActive(true);
        StartCoroutine("GetReady");


    }    


}