using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string charName;
    private int charRank;

    // �⺻ ������
    public Character()
    {
        charName = "Default";
        charRank = 0;
    }

    // �����ε��� ������
    public Character(string charName, int charRank)
    {
        this.charName = charName;
        this.charRank = charRank;
    }

    // ��: ĳ���� ���� ��¿� �޼���
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