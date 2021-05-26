//FindPlayer
//By: Lex King
//Basic AI for enemy turret.
//=============//

using UnityEngine;
using System.Collections;

public class FindPlayer : MonoBehaviour
{
    public float speed = 2.0f;

    GameObject m_target = null;
    Vector3 m_lastKnownPosition = Vector3.zero;
    Quaternion m_lookAtRotation;

    // Update is called once per frame
    void Update()
    {
        if (m_target)
        {
            if (m_lastKnownPosition != m_target.transform.position)
            {
                m_lastKnownPosition = m_target.transform.position;
                m_lookAtRotation = Quaternion.LookRotation(m_lastKnownPosition - transform.position);
            }

            if (transform.rotation != m_lookAtRotation)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, m_lookAtRotation, speed * Time.deltaTime);
            }
        }
    }

    public void SetTarget(GameObject Player)
    {
        m_target = Player;
    }
}

