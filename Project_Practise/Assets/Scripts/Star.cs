using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Star : MonoBehaviour
{
    // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    // star += "��"; // ��
    // star += "��"; // ��ĭ
    // star += "\n"; // �ٹٲ�

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
            star += "��";
        }
    }
    void AddSpace(int iteration)
    {
        for (int i = 0;i < iteration; i++)
        {
            star += "��";
        }
    }
}
