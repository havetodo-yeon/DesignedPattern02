using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPPSubject : MonoBehaviour, PSubject
{
    private List<PObserver> m_PObservers = new List<PObserver>();

    public Slider mySlider; //
    public Slider enemySlider;  //

    private float m_HP;
    private float enemy_HP;

    public void SetHP(float M_HP, float E_HP)
    {
        m_HP = M_HP;
        enemy_HP = E_HP;

        mySlider.value = M_HP;//
        enemySlider.value = E_HP;//

        Notify();
    }

    public void Notify()
    {
        foreach(var pocketmon in m_PObservers)
        {
            pocketmon.PObserverUpdate(m_HP, enemy_HP);
        }
    }

    public void Register(PObserver observer)
    {
        m_PObservers.Add(observer);
    }

    public void Remove(PObserver observer)
    {
        m_PObservers.Remove(observer);
    }
}
