using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player1End;
    public GameObject player2End;

    public float restartDelay = 1f;



    public void OnPlayer1Death(){

        player1End.SetActive(true);
        player1End.GetComponent<AudioSource>()?.Play();
        Invoke(nameof(Reset), restartDelay);
    }
    public void OnPlayer2Death(){

        player2End.SetActive(true);
        player2End.GetComponent<AudioSource>()?.Play();
        Invoke(nameof(Reset), restartDelay);
    }


    private void Reset(){
        SceneManager.LoadScene("Title");
        //#SceneManager.GetActiveScene().name

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
