using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUI : MonoBehaviour
{
    public float healthPanelOffset = 0f;
    private Rect HealthUp;
    private Rect HealthDown;
    void Start()
    {
        HealthUp = new Rect(50, 50, 100, 30);
        HealthDown = new Rect(200, 50, 100, 30);
    }
    private void OnGUI()
    {
        if(GUI.Button(HealthUp, "Health Up"))
        {
            healthPanelOffset = healthPanelOffset + 0.1f;
        }
        if (GUI.Button(HealthDown, "Health Down"))
        {
            healthPanelOffset = healthPanelOffset - 0.1f;
        }
        if (healthPanelOffset > 2f) healthPanelOffset = 2f;
        if (healthPanelOffset < 0f) healthPanelOffset = 0f;
        Vector3 worldPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector2 screenPos = Camera.main.WorldToScreenPoint(worldPos);
        Rect rect = new Rect(screenPos.x - 50, screenPos.y-20, 100, 100);
        GUI.HorizontalScrollbar(rect, 0, healthPanelOffset, 0, 2f);
    }
}