using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void IrJOgo()
    {
        SceneManager.LoadScene("Fase");
    }

    public void Credito()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void IrMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}


