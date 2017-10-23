using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToButton : MonoBehaviour {

    public GameObject storePanel;
    public GameObject statePanel;
    public Text scoreUI;
    public Text ItemCount1;
    public Text ItemCount2;
    public Text ItemCount3;
    public Text notice;

    public Text description;
    public RectTransform progress1;
    public Text prtext1;
    public RectTransform progress2;
    public Text prtext2;

	public AudioSource audioSource;
	public AudioClip audioClip;
    public AudioClip audioClip2;
    public float lowPitchRange = .95f;            
    public float highPitchRange = 1.05f;

    bool isStore = true;
    bool isState = true;

    public Text speech;
    public Image gossipbox;
    Color clear = new Color(1, 1, 1, 0);


    string[] text = new string[]
       {
           "참 잘했어요!", "대단해요!", "놀라워요!" ,"오늘도 행복하세요",
           "당신이 자랑스러워요",  "활기차고 즐거운 하루 보내세요!" ,  "밝은 모습이 참 보기 좋아요!",
            "칭찬은 고래도 춤추게 합니다~!",  "어떤 고난의 한가운데 있더라도 노력으로\n정복해야 해요",
             "역경은 희망에 의해서 극복되요", "사람은 희망이 있는 한 젊고 실망과 함께 늙습니다",  "나는 의지가 강하다 라고 외쳐보세요!",
              "희망만 있으면 행복의 싹은\n 그 곳에서 움틀어요","그대여~ 아무 걱정하지 말아요!", "어떤 종류의 성공이든 인내보다 더 필수적인\n자질은 없어요",
              "나는 성공한 사람이다 라고 외쳐보세요",  "위기는 곧 기회에요!!", "오늘은 숫자 세기를 해봐요!\n100부터 7씩 빼면서 세는거에요!",
               "멋지게 숨쉬기 대결할까요?\n전 자신있어요!",  "오늘 엄청 좋은 꿈을 꿨어요\n아주 커다란 리본을 받았거든요!"

       };
    
    void Start()
    {
        if (GlobalScore.sugo)
            speech.text = "수고하셨습니다!~";
        
    }
    public void speech_free()
    {
        int nums;
        playSpeech();
        //int tempX = Random.RandomRange(200, 400);
        //int tempY = Random.RandomRange(300, 400);
        //this.transform.position = new Vector3(tempX, tempY, 0);
        //this.transform.position = new Vector3(goch.transform.position.x + 10, goch.transform.position.y + 250, 0);
        // this.transform.position = new Vector3(244, 380, 0);

        StartCoroutine(Fade(1));
        System.Random r = new System.Random();
        nums = r.Next(0, text.Length);
        
        speech.text = text[nums];
    }
    IEnumerator Fade(float time)
    {
        float speed = 3 / time;
        float percent = 0;

        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            speech.color = Color.Lerp(Color.clear, Color.black, percent);
            gossipbox.color = Color.Lerp(clear, Color.white, percent);
            yield return null;
        }
    }
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
    //상점 코드
    public void store()
    {
        playClip();
        ItemCount1.text = "Item : " + GlobalScore.item1;
        scoreUI.text =GlobalScore.score+" $";
        if (isStore)
        {
            if (isState==false)
            {
                isState = true;
                statePanel.SetActive(false);
            }
            storePanel.SetActive(true);
            isStore = false;
        }
        else
        {
            storePanel.SetActive(false);
            isStore = true;
        }
    }
    public void buyItem1()
    {
        if (GlobalScore.score > 0)
        {
            GlobalScore.score -= 1;
            GlobalScore.item1 += 1;
            ItemCount1.text = "Item : " + GlobalScore.item1;
            scoreUI.text = GlobalScore.score + " $";
            notice.text = "구입하셨습니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
        else
        {
            notice.text = "스코어가 부족합니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
    }
    public void giveItem1()
    {
        if (GlobalScore.item1 > 0)
        {
            GlobalScore.item1 -= 1;
            GlobalScore.life += 1;
            ItemCount1.text = "Item : " + GlobalScore.item1;
            notice.text = "선물하셨습니다.\n활기가 +1 올라갔습니다!";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
            // storePanel.SetActive(false);
        }
        else
        {
            notice.text = "아이템이 부족합니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
    }
    public void buyItem2()
    {
        if (GlobalScore.score > 0)
        {
            GlobalScore.score -= 2;
            GlobalScore.item2 += 1;
            ItemCount2.text = "Item : " + GlobalScore.item2;
            scoreUI.text = GlobalScore.score + " $";
            notice.text = "구입하셨습니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
        else
        {
            notice.text = "스코어가 부족합니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
    }
    public void giveItem2()
    {
        if (GlobalScore.item2 > 0)
        {
            GlobalScore.item2 -= 1;
            GlobalScore.famility += 2;
            ItemCount2.text = "Item : " + GlobalScore.item2;
            notice.text = "선물하셨습니다.\n활기가 +2 올라갔습니다!";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
            // storePanel.SetActive(false);
        }
        else
        {
            notice.text = "아이템이 부족합니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
    }
    public void buyItem3()
    {
        if (GlobalScore.score > 0)
        {
            GlobalScore.score -= 3;
            GlobalScore.item3 += 1;
            ItemCount3.text = "Item : " + GlobalScore.item3;
            scoreUI.text = GlobalScore.score + " $";
            notice.text = "구입하셨습니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
        else
        {
            notice.text = "스코어가 부족합니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
    }
    public void giveItem3()
    {
        if (GlobalScore.item3 > 0)
        {
            GlobalScore.item3 -= 1;
            GlobalScore.life += 3;
            ItemCount3.text = "Item : " + GlobalScore.item3;
            notice.text = "선물하셨습니다.\n활기가 +3 올라갔습니다!";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
            // storePanel.SetActive(false);
        }
        else
        {
            notice.text = "아이템이 부족합니다.";
            StartCoroutine(Fade(Color.clear, Color.black, 1));
        }
    }

    IEnumerator Fade(Color from, Color to, float time)
    {
        float speed = 2 / time;
        float percent = 0;

        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            notice.color = Color.Lerp(from, to, percent);
            yield return null;
        }
    }
    public void ItemPanelExit()
    {
        storePanel.SetActive(false);
        isStore = true;
    }
    //상점 코드 끝


    //상태창 시작
    public void state()
    {
        playClip();
        if (isStore==false)
        {
            isStore=true;
            storePanel.SetActive(false);
        }
        float progressPercent1 = 0;
        float progressPercent2 = 0;
        
        progressPercent1 = GlobalScore.famility / 100f;        
        progress1.localScale = new Vector3(progressPercent1, 1, 1);
        prtext1.text = (progressPercent1*100f)+" %";
        
        
        progressPercent2 = GlobalScore.life / 100f;
        progress2.localScale = new Vector3(progressPercent2, 1, 1);
        prtext2.text = (progressPercent2*100f)+" %";

        if (isState)
        {
            statePanel.SetActive(true);            
            isState = false;
        }
        else
        {
            statePanel.SetActive(false);
            isState = true;
        }
    }
    public void statePenlExit()
    {
        statePanel.SetActive(false);
        isState = true;
    }
    public void stateFamily()
    {
        description.text = "게임을 하면 늘어납니다.";
    }
    public void stateLife()
    {
        description.text = "선물을 하면 늘어납니다.";
    }

    //상태창 끝





    public void exit()
    {
        playClip();
        Application.Quit();
    }

    public void color_start()
    {
        playClip();
        SceneManager.LoadScene(2);
    }

    public void num_start()
    {
        playClip();
        SceneManager.LoadScene(3);
    }
    public void maze_start()
    {
        playClip();
        SceneManager.LoadScene(1);
    }


    public void PlaySingle(AudioClip clip)
    {
        audioSource.volume = 0.5f;
        audioSource.clip = clip;
        audioSource.Play();
        
    }

    //소리 랜덤 변환 함수
    public void RandomizeSfx(AudioClip clips)
    {
       
       // int randomIndex = Random.Range(0, clips.Length);        
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
        audioSource.pitch = randomPitch;
        audioSource.volume = 0.4f;
        audioSource.clip = clips;
        audioSource.Play();
    }


    public void playClip(){
        // audioSource.volume = 0.5f;
        //audioSource.clip = audioClip;
        //audioSource.Play();
        RandomizeSfx(audioClip);
    }
    public void playSpeech()
    {
        PlaySingle(audioClip2);
    }

}
