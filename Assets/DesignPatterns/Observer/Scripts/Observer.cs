using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    // �������� ���� �߻� Ŭ����
    // ���������� �����ؾ� �� ��ɵ��� ����ֽ��ϴ�.(�������̽��� ����)
    public abstract void OnNotify(int number);
}
