using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
<<<<<<< HEAD
    //define vars and vectors needed for the game
    [SerializeField] public Player player;
=======
    public Player player;
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57

    [SerializeField]
    private GameObject target;

    [SerializeField]
    private Texture2D cursorTexture;

    private Vector2 cursorHotspot;

    private Vector2 mousePos;

    [SerializeField]

<<<<<<< HEAD
    private Text readyText;
=======
    private Text getReadyText;
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57

    [SerializeField]

    private Text playerLivesText;

    [SerializeField]

    private GameObject resultsPanel;

    [SerializeField]

    private Text scoreText, targetsHitText, shotsFiredText, accuracyText;

    public static int score, targetsHit, playerLives, targetsAmount, userMiss;


<<<<<<< HEAD
    private float shotsFired,shotsMissed;
=======
    private float shotsFired;
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57

    private float accuracy;

    //private int targetsAmount;

    private Vector2 targetRandomPosition;

    void Start(){
<<<<<<< HEAD
        //sets cursor to middle of screen
=======

>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height /2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);

        
<<<<<<< HEAD
        //ready text does not show
        readyText.gameObject.SetActive(false);

        //initialize vars
        targetsAmount = 1000;
=======

        getReadyText.gameObject.SetActive(false);

        //initialize vars
        targetsAmount = 50;
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        score = 0;
        shotsFired = 0;
        targetsHit = 0;
        accuracy = 0f;
        



    }
    void Update(){
<<<<<<< HEAD
        //increment shots fired by one everytime mouse is clicked
=======
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        if(Input.GetMouseButtonDown(0)){
            shotsFired += 1f;

        }


    }

    private IEnumerator GetReady(){
<<<<<<< HEAD
        //get read countdown for 3 seconds
        for(int i= 3; i>0; i--){
            readyText.text = "Ready?\n" + i.ToString();
=======
        for(int i= 3; i>0; i--){
            getReadyText.text = "Ready?\n" + i.ToString();
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
            yield return new WaitForSeconds(1f);


        }
<<<<<<< HEAD
        //changes text to go 
        readyText.text = "Go!";
        yield return new WaitForSeconds(1f);
        //starts spawning targets
=======
        getReadyText.text = "Go!";
        yield return new WaitForSeconds(1f);

>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        StartCoroutine("SpawnTargets");


    }

<<<<<<< HEAD
    //spawn targets function
    private IEnumerator SpawnTargets(){
        //ready text is inactive
        readyText.gameObject.SetActive(false);
        //initalize resets vars after every run
        score=0;
        shotsFired=0;
        shotsMissed=0;
=======
    private IEnumerator SpawnTargets(){

        getReadyText.gameObject.SetActive(false);
        
        score=0;
        shotsFired=-3;
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        targetsHit=0;
        accuracy=0;
        playerLives=3;

<<<<<<< HEAD
        //shows player lives count
        playerLivesText.gameObject.SetActive(true);
        playerLivesText.text = "Lives: " + playerLives.ToString();

        //will run the game until targets amount is gone
        for(int i = targetsAmount; i>0; i--){
            //randomizes target pos
=======
        playerLivesText.gameObject.SetActive(true);
        playerLivesText.text = "Lives: " + playerLives.ToString();

        for(int i = targetsAmount; i>0; i--){
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
            targetRandomPosition = new Vector2(Random.Range(-7f,7f), Random.Range(-4f,4f));
            Instantiate(target, targetRandomPosition, Quaternion.identity);

            yield return new WaitForSeconds(0.7f);
<<<<<<< HEAD
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
=======
            if(userMiss==1){
                playerLives--;
                shotsFired++;
                playerLivesText.text = "Lives: " + playerLives.ToString();
            }
            if(playerLives<=0){
                break;
            }  

        }

>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        resultsPanel.SetActive(true);
        scoreText.text = "Score: " + score;
        targetsHitText.text = "Targets Hit: " + targetsHit + "/" + targetsAmount;
        shotsFiredText.text = "Shots Fired: " + shotsFired;
<<<<<<< HEAD
        accuracy = (float)targetsHit/(float)(shotsFired + shotsMissed) * 100f;
        accuracyText.text = "Accuracy: " + accuracy.ToString("N2") + "%";
        //saves score to skills points
=======
        accuracy = (float)targetsHit/(float)shotsFired * 100f;
        accuracyText.text = "Accuracy: " + accuracy.ToString("N2") + "%";
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        player.AddSkill((int)(score*accuracy/1000));
        player.SavePlayer();



    }
<<<<<<< HEAD
    //funct to start the game when the player clicks the "start training" button
    public void StartGetReadyCoroutine(){

        resultsPanel.SetActive(false);
        readyText.gameObject.SetActive(true);
=======
    public void StartGetReadyCoroutine(){

        resultsPanel.SetActive(false);
        getReadyText.gameObject.SetActive(true);
>>>>>>> a8c047bf365abed148d126d25c71d802df26af57
        StartCoroutine("GetReady");


    }    


}