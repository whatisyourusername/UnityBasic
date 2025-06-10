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
        // 초기 가챠 결과 리셋
        textBox.text = "";
        counter = 0;
        counter2 = 0;
        baseNumber = 101;
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
        characterList.Add(new Character("3성무기", 3));
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
            textBox.text += $"캐릭터 이름: {charName}, {charRank}성급\n";
            Debug.Log($"요이미야가 {counter}스택에 나왔습니다.");
            counter = 0;
            fiveStarChance = defFiveStarChance;
        }
        else if (RandomChance(fourStarChance))
        {
            int index = UnityEngine.Random.Range(1, 10);
            string charName = characterList[index].GetCharName();
            int charRank = characterList[index].GetCharRank();
            textBox.text += $"캐릭터 이름: {charName}, {charRank}성급\n";
            Debug.Log($"4성 캐릭터가 {counter2}스택에 나왔습니다.");
            counter2 = 0;
            fourStarChance = defFourStarChance;
        }
        else
        {
            string charName = characterList[10].GetCharName();
            int charRank = characterList[10].GetCharRank();
            textBox.text += $"캐릭터 이름: {charName}, {charRank}성급\n";
        }
        // 확률을 일정하게 유지해주기 위해서
        baseNumber = 101;

        // 천장
        if (counter >= 73)
        {
            fiveStarChance += 6;
        }
        // 4성 천장
        if (counter2 >= 8)
        {
            fourStarChance += 51;
        }
    }

    public void gatchaOne()
    {
        textBox.text = "";
        gatcha();
        Debug.Log($"스택: {counter} / {counter2}");
    }

    public void gatchaTen()
    {
        textBox.text = "";
        for (int i = 0; i < 10; i++) 
        {
            gatcha();
        }
        Debug.Log($"스택: {counter} / {counter2}");
    }


    //void ChangeBanner(int number)
    //{
    //    bannerIndex = number;
    //}
}


