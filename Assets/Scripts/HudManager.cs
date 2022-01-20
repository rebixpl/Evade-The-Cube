using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    public Text Health;

    public void UpdateHealthText(float health)
    {
        Health.text = $"Health: {health}";
    }
}
