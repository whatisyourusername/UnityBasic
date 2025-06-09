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
        // 초기 가챠 결과 리셋
        textBox.text = "";
        // 캐릭터 생성
        characterList.Add(new Character("요이미야", 5));
        characterList.Add(new Character("운근", 4));
        characterList.Add(new Character("고로", 4));
        characterList.Add(new Character("요요", 4));
        characterList.Add(new Character("남연", 4));
        characterList.Add(new Character("신염", 4));
        characterList.Add(new Character("연비", 4));
        characterList.Add(new Character("향릉", 4));
        characterList.Add(new Character("베넷", 4));
        characterList.Add(new Character("엠버", 4));

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
            textBox.text += $"캐릭터 이름: {charName}, {charRank}성급\n";
        }
        else
        {
            int index = UnityEngine.Random.Range(1, 10);
            string charName = characterList[index].GetCharName();
            int charRank = characterList[index].GetCharRank();
            textBox.text += $"캐릭터 이름: {charName}, {charRank}성급\n";
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


