using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text;

public class TextSpeech : MonoBehaviour {

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
              "나는 성공한 사람이다 라고 외쳐보세요",  "위기는 곧 기회다라고 윈스턴 처칠이 말했어요", "오늘은 숫자 세기를 해봐요!\n100부터 7씩 빼면서 세는거에요!",
               "멋지게 숨쉬기 대결할까요?\n전 자신있어요!",  "오늘 엄청 좋은 꿈을 꿨어요\n아주 커다란 리본을 받았거든요!"

       };
    
    public void speech_free()
	{
		int nums;

        

        int tempX = Random.RandomRange(200, 400);
        int tempY = Random.RandomRange(300, 400);

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
        float speed = 1 / time;
        float percent = 0;

        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            speech.color = Color.Lerp(Color.clear, Color.black, percent);
            gossipbox.color = Color.Lerp(clear, Color.white, percent);
            yield return null;
        }
    }
}
