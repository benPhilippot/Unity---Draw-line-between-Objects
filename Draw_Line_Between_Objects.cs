using UnityEngine;

[ExecuteInEditMode]

public class Draw_Line_Between_Objects : MonoBehaviour
{
    [SerializeField] private LineRenderer line;
    [SerializeField] private GameObject ObjectA;
    [SerializeField] private GameObject ObjectB;

    void Update()
    {
        updateLineRendererPosition();
    }

    void updateLineRendererPosition()
    {
        if (line == null || ObjectA == null || ObjectB == null)
            return;

        line.SetPosition(0, ObjectA.transform.position);

        line.SetPosition(1, ObjectB.transform.position);
    }
}
