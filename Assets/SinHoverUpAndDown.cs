using UnityEngine;

public class SinHoverUpAndDown : MonoBehaviour
{
    [SerializeField]
    private float m_hoverSpeed = 1.0f;

    [SerializeField]
    private float m_hoverHeight = 0.2f;

    private float m_startYposition = 0f;

    private Vector3 m_updatedPosition;

    private void Start()
    {
        m_startYposition = transform.position.y;
    }

    private void Update()
    {
        m_updatedPosition.x = transform.position.x;
        m_updatedPosition.y = m_startYposition +
            (m_hoverHeight * Mathf.Sin(Time.time * m_hoverSpeed));
        m_updatedPosition.z = transform.position.z;

        transform.position = m_updatedPosition;
    }
}
