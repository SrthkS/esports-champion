using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private GameObject target;

    [SerializeField]
    private Texture2D cursorTexture;

    private Vector2 cursorHotspot;

    private Vector2 mousePos;

    [SerializeField]

    private Text getReadyText;

    [SerializeField]

    private GameObject resultsPanel;

    [SerializeField]

    private Text scoreText, targetsHitText, shotsFiredText, accuracyText;

    public static int score, targetsHit;


    private float shotsFired;

    private float accuracy;

    private int targetsAmount;

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
        for(int i= 3; i>=1; i--){
            getReadyText.text = "Ready?!\n" + i.ToString();
            yield return new WaitForSeconds(1f);


        }
        getReadyText.text = "Go!";
        yield return new WaitForSeconds(1f);

        StartCoroutine("SpawnTargets");


    }

    private IEnumerator SpawnTargets(){
        getReadyText.gameObject.SetActive(false);
        score = 0;
        shotsFired = 0;
        targetsHit=0;
        accuracy=0;

        for(int i = targetsAmount; i>=0; i--){
            targetRandomPosition = new Vector2(Random.Range(-7f,7f), Random.Range(-4f,4f));
            Instantiate(target, targetRandomPosition, Quaternion.identity);

            yield return new WaitForSeconds(1f);

        }

        resultsPanel.SetActive(true);
        scoreText.text = "Score: " + score;
        targetsHitText.text = "Targets Hit: " + targetsHit + "/" + targetsAmount;
        shotsFiredText.text = "Shots Fired: " + shotsFired;
        accuracy = targetsHit/shotsFired * 100f;
        accuracyText.text = "Accuracy: " + accuracy.ToString("N2") + " %";


    }
    public void StartGetReadyCoroutine(){
        resultsPanel.SetActive(false);
        getReadyText.gameObject.SetActive(true);
        StartCoroutine("Get Ready");


    }    


}