using System;
using System.Diagnostics;

public class Nemico : MonoBehaviour
{
    public enum TipoNemico { Zombie, Robot, Fantasma }
    [SerializeField]
    private TipoNemico tipo;
    private void Start()
    {
        switch (tipo)
        {
            case TipoNemico.Zombie:
                Debug.Log("Questo è uno zombie");
                break;
            case TipoNemico.Robot:
                Debug.Log("Questo è un robot");
                break;
            case TipoNemico.Fantasma:
                Debug.Log("Questo è un fantasma");
            break;
        }
    }
}