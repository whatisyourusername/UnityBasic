using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GatchaScript : MonoBehaviour
{
    public int bannerChance = 5;
    public TextMeshProUGUI textBox;

    private int bannerIndex;
    List<Character> characterList = new List<Character>();
    // List<Character> gatchaResult = new List<Character>();
    // Start is called before the first frame update
    void Start()
    {
        // �ʱ� ��í ��� ����
        textBox.text = "";
        // ĳ���� ����
        characterList.Add(new Character("���̹̾�", 5));
        characterList.Add(new Character("���", 4));
        characterList.Add(new Character("���", 4));
        characterList.Add(new Character("���", 4));
        characterList.Add(new Character("����", 4));
        characterList.Add(new Character("�ſ�", 4));
        characterList.Add(new Character("����", 4));
        characterList.Add(new Character("�⸪", 4));
        characterList.Add(new Character("����", 4));
        characterList.Add(new Character("����", 4));

        for (int i = 0; i < characterList.Count; i++)
        {
            characterList[i].PrintInfo();
        }
    }

    bool RandomChance(int number)
    {
        int randomNumber = UnityEngine.Random.Range(1, 101);
        if (randomNumber <= number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void gatcha()
    {
        if (RandomChance(bannerChance))
        {
            string charName = characterList[0].GetCharName();
            int charRank = characterList[0].GetCharRank();
            textBox.text += $"ĳ���� �̸�: {charName}, {charRank}����\n";
        }
        else
        {
            int index = UnityEngine.Random.Range(1, 10);
            string charName = characterList[index].GetCharName();
            int charRank = characterList[index].GetCharRank();
            textBox.text += $"ĳ���� �̸�: {charName}, {charRank}����\n";
        }
    }

    public void gatchaOne()
    {
        textBox.text = "";
        gatcha();
    }

    public void gatchaTen()
    {
        textBox.text = "";
        for (int i = 0; i < 10; i++) 
        {
            gatcha();
        }
    }


    //void ChangeBanner(int number)
    //{
    //    bannerIndex = number;
    //}
}


