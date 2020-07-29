using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public void WorldMapLoad()
    {
        SceneManager.LoadScene(1); // Лучше использовать имена сцен, чтобы не зависеть от их расстановке в билдере
    }
    public void CharInfoLoad()
    {
        SceneManager.LoadScene(2);
    }
    public void ToChoice()
    {
        SceneManager.LoadScene(0);
    }
}
