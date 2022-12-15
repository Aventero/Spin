using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyColoringManager : MonoBehaviour
{
    public Material PlanetMaterial;
    // Start is called before the first frame update
    void Update()
    {
        switch (SaveManager.Difficulty)
        {
            case Difficulty.Easy: PlanetMaterial.SetColor("_GlowColor", new Color(0f, 7, 20, 0)); break;
            case Difficulty.Medium: PlanetMaterial.SetColor("_GlowColor", new Color(20, 1, 15, 0)); break;
            case Difficulty.Hard: PlanetMaterial.SetColor("_GlowColor", new Color(10, 4, 0.15f, 0)); break;
            case Difficulty.Extreme: PlanetMaterial.SetColor("_GlowColor", new Color(30, 0.1f, 0.5f, 0)); break;
        }
    }
}
