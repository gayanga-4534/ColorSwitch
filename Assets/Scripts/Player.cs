using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
AudioSource jumpsound;
// AudioSource gameoversound;
public SpriteRenderer sR;
private Rigidbody2D rb;
public float jumpHeight;
public string currentColor;

public float score;
public TextMeshProUGUI scoreText;
    void Start()
    {
        RandomColor();
        rb=GetComponent<Rigidbody2D>();
        jumpsound = GetComponent<AudioSource>();
    //    gameoversound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 ){
            jump();
            scoreText.text = "" + score;
        }
    }

private void RandomColor(){

    int i= Random.Range(0, 3);

    switch (i){
        case 0:
        currentColor = "aqua";
        sR.color = new Color(0.2078432f, 0.8862746f, 0.9490197f);
        break;


         case 1:
        currentColor = "yellow";
        sR.color = new Color(0.9647059f, 0.8745099f, 0.738f);
        break;

         case 2:
        currentColor = "puple";
        sR.color = new Color(0.5490196f, 0.07450981f, 0.9803922f);
        break;

         case 3:
        currentColor = "pink";
        sR.color = new Color(1f, 0f , 0.5019608f);
        break;
    }
}

private void jump(){
    jumpsound.Play();
    rb.velocity = Vector2.up * jumpHeight;
}

private void OnCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.tag == "Ground"){
        jump();
    }



    if(collision.gameObject.tag == "Star"){
        score += 1;
       SoundManager.instance.coinsSource.PlayOneShot(SoundManager.instance.coinSound);
    }
}

private void OnTriggerEnter2D(Collider2D collision){

    if(collision.gameObject.tag == "changeColor"){
        RandomColor();
         Destroy(collision.gameObject);
         
    
    }

   else if(collision.gameObject.tag  != currentColor ){
        Debug.Log("GameOver");
        SceneManager.LoadScene("LoseGame");
        //  SoundManager.instance.coinsSource.PlayOneShot(SoundManager.instance.gameOverSound);
        // gameoversound.Play();
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}

}


