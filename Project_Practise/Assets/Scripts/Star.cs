using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Star : MonoBehaviour
{
    // 2. 별, 빈칸, 줄바꿈 추가하기
    // Debug.Log를 사용하여 콘솔창에 출력합니다
    // star += "★"; // 별
    // star += "　"; // 빈칸
    // star += "\n"; // 줄바꿈

    private string star;

    // Start is called before the first frame update
    void Start()
    {
        Star1();
        Star2();
        Star3();
        Star4();
        Star5();
    }

    void Star1()
    {
        star = "";
        for (int i = 1; i < 6; i++)
        {
            AddStar(i);
            star += "\n";
        }
        Debug.Log(star);
    }
    void Star2()
    {
        star = "";
        for (int i = 1; i < 6; i++)
        {
            AddSpace(i-1);
            AddStar(6 - i);
            star += "\n";
        }
        Debug.Log(star);
    }

    void Star3()
    {
        star = "";
        for (int i = 1; i < 10; i++)
        {
            AddStar(5 - Mathf.Abs(i - 5));            
            star += "\n";
        }
        Debug.Log(star);
    }

    void Star4()
    {
        star = "";
        for (int i = 1; i < 10; i++)
        {
            AddSpace(Mathf.Abs(i - 5));
            AddStar(5 - Mathf.Abs(i - 5));
            star += "\n";
        }
        Debug.Log(star);
    }
    void Star5()
    {
        star = "";
        for (int i = 1; i < 10; i++)
        {
            AddSpace(Mathf.Abs(i - 5));
            AddStar(9 - Mathf.Abs(i - 5) * 2);
            star += "\n";
        }
        Debug.Log(star);
    }

    void AddStar(int iteration)
    {
        for (int i = 0; i < iteration; i++)
        {
            star += "★";
        }
    }
    void AddSpace(int iteration)
    {
        for (int i = 0;i < iteration; i++)
        {
            star += "　";
        }
    }
}
