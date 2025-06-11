using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    [SerializeField] Image img_BG; // ���
    [SerializeField] Image[] img_Character = new Image[5]; // ĳ���� �̹�����

  



    [SerializeField] TextMeshProUGUI txt_Name; //ĳ���� �̸�
    [SerializeField] TextMeshProUGUI txt_ClubName; // �Ҽ� ��Ī
    [SerializeField] TextMeshProUGUI txt_Dialogue; // ĳ���� ���
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
        int characterID = SData.GetDialogueData(id).Character; // ��� ���̺��� 1�� ID�� ĳ���� ID �÷��� ������ �´�
        txt_Name.text = SData.GetCharacterData(characterID).Charname; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�
        txt_ClubName.text = SData.GetCharacterData(characterID).Charclubname; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�
        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue; //ĳ���� ���̺��� ĳ���� ID�� Ÿ��Ʋ�� ������ �´�.

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
