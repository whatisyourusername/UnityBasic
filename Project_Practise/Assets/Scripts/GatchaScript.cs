using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GatchaScript : MonoBehaviour
{
    public int defFourStarChance = 5;
    public int defFiveStarChance = 1;
    public TextMeshProUGUI textBox;

    private int fourStarChance = 5;
    private int fiveStarChance = 1;
    private int baseNumber;
    private int bannerIndex;
    private int counter;
    private int counter2;
    List<Character> characterList = new List<Character>();
    // List<Character> gatchaResult = new List<Character>();
    // Start is called before the first frame update
    void Start()
    {
        // �ʱ� ��í ��� ����
        textBox.text = "";
        counter = 0;
        counter2 = 0;
        baseNumber = 101;
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
        characterList.Add(new Character("3������", 3));
    }

    bool RandomChance(int number)
    {
        int randomNumber = UnityEngine.Random.Range(1, baseNumber);
        baseNumber -= number;
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
        counter += 1;
        counter2 += 1;
        if (RandomChance(fiveStarChance))
        {
            string charName = characterList[0].GetCharName();
            int charRank = characterList[0].GetCharRank();
            textBox.text += $"ĳ���� �̸�: {charName}, {charRank}����\n";
            Debug.Log($"���̹̾߰� {counter}���ÿ� ���Խ��ϴ�.");
            counter = 0;
            fiveStarChance = defFiveStarChance;
        }
        else if (RandomChance(fourStarChance))
        {
            int index = UnityEngine.Random.Range(1, 10);
            string charName = characterList[index].GetCharName();
            int charRank = characterList[index].GetCharRank();
            textBox.text += $"ĳ���� �̸�: {charName}, {charRank}����\n";
            Debug.Log($"4�� ĳ���Ͱ� {counter2}���ÿ� ���Խ��ϴ�.");
            counter2 = 0;
            fourStarChance = defFourStarChance;
        }
        else
        {
            string charName = characterList[10].GetCharName();
            int charRank = characterList[10].GetCharRank();
            textBox.text += $"ĳ���� �̸�: {charName}, {charRank}����\n";
        }
        // Ȯ���� �����ϰ� �������ֱ� ���ؼ�
        baseNumber = 101;

        // õ��
        if (counter >= 73)
        {
            fiveStarChance += 6;
        }
        // 4�� õ��
        if (counter2 >= 8)
        {
            fourStarChance += 51;
        }
    }

    public void gatchaOne()
    {
        textBox.text = "";
        gatcha();
        Debug.Log($"����: {counter} / {counter2}");
    }

    public void gatchaTen()
    {
        textBox.text = "";
        for (int i = 0; i < 10; i++) 
        {
            gatcha();
        }
        Debug.Log($"����: {counter} / {counter2}");
    }


    //void ChangeBanner(int number)
    //{
    //    bannerIndex = number;
    //}
}


