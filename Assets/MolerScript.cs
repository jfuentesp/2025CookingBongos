using UnityEngine;

enum Fases {UNO, DOS, ROTO}
public class MolerScript : MonoBehaviour
{
    private Fases m_fase;
    private int m_contadorDeGolpes;
    private int m_maxGolpes = 3;
    void Start()
    {
        m_fase = Fases.UNO;
        m_contadorDeGolpes = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Martillo") {
            RecibirGolpe();
        }
    }
    private void RecibirGolpe() { 
        m_contadorDeGolpes++;
        if (m_contadorDeGolpes == m_maxGolpes) {
            m_fase = Fases.DOS;
        }else if(m_contadorDeGolpes > m_maxGolpes)
        {
            m_fase = Fases.ROTO;
        }
        
    }
}
