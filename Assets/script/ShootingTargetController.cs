using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTargetController : MonoBehaviour
{
    [SerializeField] float m_minInterval = 0.8f;
    [SerializeField] float m_maxInterval = 3f;
    bool m_isAppeared = false;
    Animator m_anim = null;
    float m_timer;

    void Start()
    {
        m_anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (m_timer > 0)
        {
            m_timer -= Time.deltaTime;
        }
        else if (m_isAppeared)
        {
            Disappear();
        }
    }

    public void Appear()
    {
        m_isAppeared = true;
        m_anim.Play("Appear");
        m_timer = Random.Range(m_minInterval, m_maxInterval);
    }

    public void Disappear()
    {
        m_isAppeared = false;
        m_anim.Play("Disappear");
    }

    public void Hit()
    {
        m_isAppeared = false;
        m_anim.Play("Hide");
    }
}
