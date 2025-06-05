using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Person : MonoBehaviour
{
    // 변수
    private string userName = "플로렌스";
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
            diaText.text = $"이름은 {userName}~ 나이는 {age}살!";
            showText.text = "키랑 몸무게는?";
            counter = false;
        }
        else
        {
            diaText.text = $"{height}cm, {weight}kg...";
            showText.text = "카메라를 바라보고 \n이름과 나이를 말해보렴";
            counter = true;
        }
    }
}
