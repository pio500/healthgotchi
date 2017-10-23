using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {
    int color;
    public GameObject redimg;
    public GameObject blueimg;
    public GameObject brownimg;
    public GameObject greenimg;
    public GameObject yellowimg;
    public GameObject omark;
    public GameObject xmark;
    public UILabel scoreLabel;
	public UILabel scoreLabel_panel;
    public GameObject endgame;
	public GameObject menu;
	public GameObject back;
	public GameObject title;

	public AudioSource audioSource;
	public AudioClip audioClip;
    public AudioClip audioClip2;
    public AudioClip correct;
    public AudioClip wrong;


    public int score=0;

    public void startt() {
        redimg.SetActive(false);
        blueimg.SetActive(false);
        brownimg.SetActive(false);
        greenimg.SetActive(false);
        yellowimg.SetActive(false);
        omark.SetActive(false);
        xmark.SetActive(false);
        
        if (score > 4)
        {
            GlobalScore.sugo = true;
            PlaySingleEnd(audioClip2);
            endgame.SetActive(true);
            GlobalScore.famility += 1;
            GlobalScore.score += 2;
            Invoke("end", 2);
            return;
        }
        System.Random r = new System.Random();
        color = r.Next(1, 6);
        if (color == 1)
        {
            redimg.SetActive(true);
        }
        else if (color == 2)
        {
            blueimg.SetActive(true);
        }
        else if (color == 3)
        {
            brownimg.SetActive(true);
        }
        else if (color == 4)
        {
            greenimg.SetActive(true);
        }
        else if (color == 5)
        {
            yellowimg.SetActive(true);
        }
    }
    public void end()
    {
        SceneManager.LoadScene(0);
    }

    // Use this for initialization
    void Start () {
        
		Screen.SetResolution(1280, 720, true);
        scoreLabel.text = "Score : " + score;
		scoreLabel_panel.text = " " + score;
        startt();
    }
    public void red_clicked()
    {
        PlaySingle(audioClip);
        if (color == 1)
        {
            PlaySingle(correct);
            omark.SetActive(true);
            score += 1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);

        }
        else
        {
            PlaySingle(wrong);
            xmark.SetActive(true);
            Invoke("startt", 1f);
        }
    }
    public void blue_clicked()
    {
        PlaySingle(audioClip);
        if (color == 2)
        {
            PlaySingle(correct);
            omark.SetActive(true);
            score += 1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);

        }
        else
        {
            PlaySingle(wrong);
            xmark.SetActive(true);
            Invoke("startt", 1f);
        }
    }
    public void brown_clicked()
    {
        PlaySingle(audioClip);
        if (color == 3)
        {
            PlaySingle(correct);
            omark.SetActive(true);
            score += 1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);
        }
        else
        {
            PlaySingle(wrong);
            xmark.SetActive(true);
            Invoke("startt", 1f);
        }
    }
    public void green_clicked()
    {
        PlaySingle(audioClip);
        if (color == 4)
        {
            PlaySingle(correct);
            omark.SetActive(true);
            score += 1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);
        }
        else
        {
            PlaySingle(wrong);
            xmark.SetActive(true);
            Invoke("startt", 1f);
        }
    }
    public void yellow_clicked()
    {
        PlaySingle(audioClip);
        if (color == 5)
        {
            PlaySingle(correct);
            omark.SetActive(true);
            score += 1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);
        }
        else
        {
            PlaySingle(wrong);
            xmark.SetActive(true);
            Invoke("startt", 1f);
        }
    }

	public void menu_clicked()
	{
        PlaySingle(audioClip);
        menu.SetActive (true);
	}

	public void back_clicked()
	{
        PlaySingle(audioClip);
        menu.SetActive (false);
	}

	public void title_clicked()
	{
        PlaySingle(audioClip);
        SceneManager.LoadScene (0);
	}

    public void PlaySingle(AudioClip clip)
    {
        audioSource.volume = 0.5f;
        audioSource.clip = clip;
        audioSource.Play();

    }
    public void PlaySingleEnd(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

}
