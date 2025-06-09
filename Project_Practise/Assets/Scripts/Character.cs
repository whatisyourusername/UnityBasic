using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string charName;
    private int charRank;

    // 기본 생성자
    public Character()
    {
        charName = "Default";
        charRank = 0;
    }

    // 오버로딩된 생성자
    public Character(string charName, int charRank)
    {
        this.charName = charName;
        this.charRank = charRank;
    }

    // 예: 캐릭터 정보 출력용 메서드
    public void PrintInfo()
    {
        Debug.Log("Name: " + charName + ", Rank: " + charRank);
    }

    public string GetCharName()
    {
        return charName;
    }
    public int GetCharRank()
    {
        return charRank;
    }
}