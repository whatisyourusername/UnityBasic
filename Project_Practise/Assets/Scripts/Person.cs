using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Person : MonoBehaviour
{
    // ����
    private string userName = "�÷η���";
    private int age = 21;
    private float height = 153.6f;
    private float weight = 43.8f;
    private bool counter = true;

    // Public
    public TextMeshProUGUI showText;
    public TextMeshProUGUI diaText;

    public void SelfIntroduction1()
    {
        if (counter)
        {
            diaText.text = $"�̸��� {userName}~ ���̴� {age}��!";
            showText.text = "Ű�� �����Դ�?";
            counter = false;
        }
        else
        {
            diaText.text = $"{height}cm, {weight}kg...";
            showText.text = "ī�޶� �ٶ󺸰� \n�̸��� ���̸� ���غ���";
            counter = true;
        }
    }
}
