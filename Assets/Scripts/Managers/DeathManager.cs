using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject DeathMenu;
    public TMPro.TMP_Text TMP_Text;

    private void Awake()
    {
        HealthManager.OnDeath += EnableDeathMenu;
    }

    private void EnableDeathMenu()
    {
        GameManager.Instance.StopSpawning();
        // Show death screen
        DeathMenu.SetActive(true);
        TMP_Text.SetText("You completed " + GameManager.Instance.CurrentStage + " stages!");

        // Disable gravity on meteors
        GameObject[] meteorites = GameObject.FindGameObjectsWithTag("Meteorite");
        for (int i = 0; i < meteorites.Length; i++)
        {
            meteorites[i].GetComponent<Meteorite>().Gravity = 0.0f;
        }
    }

    private void OnDestroy()
    {
        HealthManager.OnDeath -= EnableDeathMenu;
    }
}
