using UnityEngine;

public class CalentadorScript : MonoBehaviour
{
    [SerializeField] private LlamarCalentador m_llamador;
    [SerializeField] private GameObject m_particulas;
    bool m_Calentando;
    void Start()
    {
  
    }

    private void Calentar() { 
        m_particulas.SetActive(true);
        m_Calentando = true;
    }
    private void Apagar()
    {
        m_particulas.SetActive(false);
        m_Calentando = false;
    }
}
