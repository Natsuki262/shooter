using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTargetManager : MonoBehaviour
{
    [SerializeField] ShootingTargetController[] m_targets = null;
    [SerializeField] float m_minInterval = 0.1f;
    [SerializeField] float m_maxInterval = 2f;
    float m_timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (m_timer > 0)
        {
            m_timer -= Time.deltaTime;
        }
        else
        {
            m_timer = Random.Range(m_minInterval, m_maxInterval);
            int i = Random.Range(0, m_targets.Length);
            m_targets[i].Appear();
        }
    }
}
