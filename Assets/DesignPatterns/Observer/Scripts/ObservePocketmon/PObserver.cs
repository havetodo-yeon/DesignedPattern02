using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PObserver
{
    // ������ �����ϰ� �ʱ�ȭ�ϴ� ���
    // ������ ü�°� ���� ü���� �ۼ��մϴ�.
    public abstract void PObserverUpdate(float myHp, float enemyHP);
}
