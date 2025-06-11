using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    [SerializeField] Image img_BG; // 배경
    [SerializeField] Image[] img_Character = new Image[5]; // 캐릭터 이미지들

  



    [SerializeField] TextMeshProUGUI txt_Name; //캐릭터 이름
    [SerializeField] TextMeshProUGUI txt_ClubName; // 소속 명칭
    [SerializeField] TextMeshProUGUI txt_Dialogue; // 캐릭터 대사
    [SerializeField] Button NextButton;

    [SerializeField] int id = 1;


    void Start()
    {
        RefreshUI();
    }
    // Update is called once per frame
    void Update()
    {
        if (id > 6)
        {
            id = 1;
            RefreshUI();
        }

    }


    public void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character; // 대사 테이블의 1번 ID의 캐릭터 ID 컬럼을 가지고 온다
        txt_Name.text = SData.GetCharacterData(characterID).Charname; // 캐릭터 테이블에서 캐릭터 ID에 해당하는 이름을 가지고 온다
        txt_ClubName.text = SData.GetCharacterData(characterID).Charclubname; // 캐릭터 테이블에서 캐릭터 ID에 해당하는 이름을 가지고 온다
        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue; //캐릭터 테이블에서 캐릭터 ID에 타이틀을 가지고 온다.

        img_BG.sprite = Resources.Load<Sprite>("IMG/RenPy/BG_Top" + SData.GetDialogueData(id).BG);

        for(int i = 1; i < img_Character.Length; i++)
        {

            if(i ==SData.GetDialogueData(id).Position)
            {
                img_Character[i].sprite = Resources.Load<Sprite>("IMG/RenPy" + SData.GetCharacterData(characterID).Charimage);
            }

        }


    }

    public void OnClickButton()
    {
        if (id < 6)
        {
            id++;
            RefreshUI();
        }

        else
        {
            id = 1;
            RefreshUI();
        }
    }
}
