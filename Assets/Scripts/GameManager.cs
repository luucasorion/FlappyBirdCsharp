using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    AudioManager audioManager;
    public BirdController bird;
    public Text textoPontuacao;
    public GameObject PlacaPlay;
    public GameObject gameOver;

    private int pontuacao;
    private Vector3 posicaoBird = new Vector3(0, -6.4f, 0);
    private void Awake()
    {
        gameOver.SetActive(false);
        Application.targetFrameRate = 60;
        Pause();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void Play()
    {
        pontuacao = 0;
        textoPontuacao.text = pontuacao.ToString();
        PlacaPlay.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1;
        bird.enabled = true;
        bird.transform.position = posicaoBird;
        Canos[] canos = FindObjectsOfType<Canos>();

        for ( int i = 0; i < canos.Length; i++)
        {
            Destroy(canos[i].gameObject);
        }
    
    }

    public void Pause() 
    { 
        Time.timeScale = 0;
        bird.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        PlacaPlay.SetActive(true);
        audioManager.PlaySFX(audioManager.Paranaramnaram);
        Pause();
    }

    public void Pontuando()
    {
        pontuacao += 1;
        textoPontuacao.text = pontuacao.ToString();
    }
}
