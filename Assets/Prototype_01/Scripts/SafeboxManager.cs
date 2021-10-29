using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeboxManager : MonoBehaviour
{
    [SerializeField] List<Material> origin; // �ؽ��ĸ� ������ list
    [SerializeField] List<int> correct; // ������ ����
    [SerializeField] List<int> safeboxA;
    [SerializeField] List<int> safeboxB;

    List<int> arr;  // correct�� ���� �ο��� �� ����� �� ���

    private void Awake()
    {
        correct = new List<int>();
        arr = new List<int>();
    }

    private void Start()
    {
        SetCorrect();
    }

    public void SetCorrect()
    {
        // �����̳� ����
        if (correct.Count > 0)
        {
            correct.Clear();
        }

        // arr�� origin�� index�� �Ҵ��Ѵ�.
        for (int i = 0; i < origin.Count; i++)
        {
            arr.Add(i);
        }        
        
        int value;
        int cnt = 0;

        // arr�� ���� ������ 0���� Ŭ ������ �ݺ�
        while (0 < arr.Count)
        {
            // correct�� arr�� ���� '��������' �ϳ��� �Ҵ�
            value = arr[Random.Range(0, arr.Count)];
            correct.Add(value);

            // �Ҵ� ���� correct�� ���� arr���� �����Ѵ�.
            arr.Remove(correct[cnt]);
            // cnt = index�� ����
            cnt++;
        }        
    }

    void SetSafebox()
    {

    }
    
}
