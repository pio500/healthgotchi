using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine.SceneManagement;

public class GM2 : MonoBehaviour
{
    int nums, nums2, ldop, rdop, mark;
    //ll숫자
    public UILabel scoreLabel;
	public UILabel scoreLabel_panel;
    int score=0;
    public GameObject endgame;
    public GameObject ll0;
    public GameObject ll1;
    public GameObject ll2;
    public GameObject ll3;
    public GameObject ll4;
    public GameObject ll5;
    public GameObject ll6;
    public GameObject ll7;
    public GameObject ll8;
    public GameObject ll9;
    //lr숫자
    public GameObject lr0;
    public GameObject lr1;
    public GameObject lr2;
    public GameObject lr3;
    public GameObject lr4;
    public GameObject lr5;
    public GameObject lr6;
    public GameObject lr7;
    public GameObject lr8;
    public GameObject lr9;
    //rl숫자
    public GameObject rl0;
    public GameObject rl1;
    public GameObject rl2;
    public GameObject rl3;
    public GameObject rl4;
    public GameObject rl5;
    public GameObject rl6;
    public GameObject rl7;
    public GameObject rl8;
    public GameObject rl9;
    //rl숫자
    public GameObject rr0;
    public GameObject rr1;
    public GameObject rr2;
    public GameObject rr3;
    public GameObject rr4;
    public GameObject rr5;
    public GameObject rr6;
    public GameObject rr7;
    public GameObject rr8;
    public GameObject rr9;

    public GameObject lplus;
    public GameObject lminus;
    public GameObject lmulti;
    public GameObject ldiv;

    public GameObject rplus;
    public GameObject rminus;
    public GameObject rmulti;
    public GameObject rdiv;

    public GameObject omark;
    public GameObject xmark;

	public GameObject menu;
	public GameObject back;
	public GameObject title;

	public AudioSource audioSource;
	public AudioClip audioClip;
    public AudioClip endclip;
    public AudioClip correct;
    public AudioClip wrong;


    public void allflase()
    {
        ll0.SetActive(false);
        ll1.SetActive(false);
        ll2.SetActive(false);
        ll3.SetActive(false);
        ll4.SetActive(false);
        ll5.SetActive(false);
        ll6.SetActive(false);
        ll7.SetActive(false);
        ll8.SetActive(false);
        ll9.SetActive(false);

        lr0.SetActive(false);
        lr1.SetActive(false);
        lr2.SetActive(false);
        lr3.SetActive(false);
        lr4.SetActive(false);
        lr5.SetActive(false);
        lr6.SetActive(false);
        lr7.SetActive(false);
        lr8.SetActive(false);
        lr9.SetActive(false);

        rl0.SetActive(false);
        rl1.SetActive(false);
        rl2.SetActive(false);
        rl3.SetActive(false);
        rl4.SetActive(false);
        rl5.SetActive(false);
        rl6.SetActive(false);
        rl7.SetActive(false);
        rl8.SetActive(false);
        rl9.SetActive(false);

        rr0.SetActive(false);
        rr1.SetActive(false);
        rr2.SetActive(false);
        rr3.SetActive(false);
        rr4.SetActive(false);
        rr5.SetActive(false);
        rr6.SetActive(false);
        rr7.SetActive(false);
        rr8.SetActive(false);
        rr9.SetActive(false);

        lplus.SetActive(false);
        lminus.SetActive(false);
        lmulti.SetActive(false);
        ldiv.SetActive(false);

        rplus.SetActive(false);
        rminus.SetActive(false);
        rmulti.SetActive(false);
        rdiv.SetActive(false);

        omark.SetActive(false);
        xmark.SetActive(false);
    }
    public void startt()
    {
        if (score > 4)
        {
            PlaySingleEnd(endclip);
            GlobalScore.sugo = true;
            endgame.SetActive(true);
            GlobalScore.famility += 1;
            GlobalScore.score += 1;
            Invoke("end", 2);
            return;
        }
        allflase();
        ldop = 0;
        rdop = 0;
        System.Random r = new System.Random();
        nums = r.Next(0, 10);         
        nums2 = r.Next(0, 10);
        mark = r.Next(0, 4);
        //ll숫자
        if (nums == 0)
            ll0.SetActive(true);
        else if (nums == 1)
            ll1.SetActive(true);
        else if (nums == 2)
            ll2.SetActive(true);
        else if (nums == 3)
            ll3.SetActive(true);
        else if (nums == 4)
            ll4.SetActive(true);
        else if (nums == 5)
            ll5.SetActive(true);
        else if (nums == 6)
            ll6.SetActive(true);
        else if (nums == 7)
            ll7.SetActive(true);
        else if (nums == 8)
            ll8.SetActive(true);
        else if (nums == 9)
            ll9.SetActive(true);


        if (mark == 0)
        {
            lplus.SetActive(true);
            ldop = nums + nums2;
        }

        else if (mark == 1)
        {
            lminus.SetActive(true);
            ldop = nums - nums2;
        }

        else if (mark == 2)
        {
            lmulti.SetActive(true);
            ldop = nums * nums2;
        }
        else if (mark == 3)
        {
            ldiv.SetActive(true);
            if (nums == 0 || nums2 == 0) { rdop = 0; }
            else
                ldop = nums / nums2;
        }


        //lr숫자
        if (nums2 == 0)
            lr0.SetActive(true);
        else if (nums2 == 1)
            lr1.SetActive(true);
        else if (nums2 == 2)
            lr2.SetActive(true);
        else if (nums2 == 3)
            lr3.SetActive(true);
        else if (nums2 == 4)
            lr4.SetActive(true);
        else if (nums2 == 5)
            lr5.SetActive(true);
        else if (nums2 == 6)
            lr6.SetActive(true);
        else if (nums2 == 7)
            lr7.SetActive(true);
        else if (nums2 == 8)
            lr8.SetActive(true);
        else if (nums2 == 9)
            lr9.SetActive(true);



        nums = r.Next(0, 10);
        nums2 = r.Next(0, 10);
        print(nums); print(nums2); 
        mark = r.Next(0, 4);
        print(mark);
        //rl숫자
        if (nums == 0)
            rl0.SetActive(true);
        else if (nums == 1)
            rl1.SetActive(true);
        else if (nums == 2)
            rl2.SetActive(true);
        else if (nums == 3)
            rl3.SetActive(true);
        else if (nums == 4)
            rl4.SetActive(true);
        else if (nums == 5)
            rl5.SetActive(true);
        else if (nums == 6)
            rl6.SetActive(true);
        else if (nums == 7)
            rl7.SetActive(true);
        else if (nums == 8)
            rl8.SetActive(true);
        else if (nums == 9)
            rl9.SetActive(true);


        if (mark == 0)
        {
            rplus.SetActive(true);
            rdop = nums + nums2;
        }

        else if (mark == 1)
        {
            rminus.SetActive(true);
            rdop = nums - nums2;
        }

        else if (mark == 2)
        {
            rmulti.SetActive(true);
            rdop = nums * nums2;
        }
        else if (mark == 3)
        {
            rdiv.SetActive(true);
            if (nums == 0 || nums2==0) { rdop = 0; }
            else
                rdop = nums / nums2;
        }


        //rr숫자
        if (nums2 == 0)
            rr0.SetActive(true);
        else if (nums2 == 1)
            rr1.SetActive(true);
        else if (nums2 == 2)
            rr2.SetActive(true);
        else if (nums2 == 3)
            rr3.SetActive(true);
        else if (nums2 == 4)
            rr4.SetActive(true);
        else if (nums2 == 5)
            rr5.SetActive(true);
        else if (nums2 == 6)
            rr6.SetActive(true);
        else if (nums2 == 7)
            rr7.SetActive(true);
        else if (nums2 == 8)
            rr8.SetActive(true);
        else if (nums2 == 9)
            rr9.SetActive(true);


    }
    // Use this for initialization
    void Start()
    {		
		Screen.SetResolution(1280, 720, true);
        startt();
    }
    public void end()
    {
        SceneManager.LoadScene(0);
    }

    public void leftwin()
    {
        PlaySingle(audioClip);
        if (ldop > rdop)
        {
            PlaySingleEnd(correct);
            omark.SetActive(true);
            score +=1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);

        }
        else
        {
            PlaySingleEnd(wrong);
            xmark.SetActive(true);
            Invoke("startt", 1f);
        }
    }
    public void rightwin()
    {
        PlaySingle(audioClip);
        if (ldop < rdop)
        {
            PlaySingleEnd(correct);
            omark.SetActive(true);
            score += 1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);

        }
        else
        {
            PlaySingleEnd(wrong);
            xmark.SetActive(true);
            Invoke("startt", 1f);
        }
    }
    public void equal()
    {
        PlaySingle(audioClip);
        if (ldop == rdop)
        {
            PlaySingleEnd(correct);
            omark.SetActive(true);
            score += 1;
            scoreLabel.text = "Score : " + score;
			scoreLabel_panel.text = " " + score;
            Invoke("startt", 1f);
        }
        else
        {
            PlaySingleEnd(wrong);
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
