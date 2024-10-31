using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class LlamarCalentador : MonoBehaviour
{
    public Action Calentar;
    public Action Apagar;
    private XRGrabInteractable m_interactable;
    void Start()
    {
        m_interactable = GetComponent<XRGrabInteractable>();
        m_interactable.selectEntered.AddListener(Calentador);
        m_interactable.selectExited.AddListener(ApagarCalentador);
    }



    private void Calentador(SelectEnterEventArgs _)
    {
        Calentar?.Invoke();
    }

    private void ApagarCalentador(SelectExitEventArgs _)
    {
        Apagar?.Invoke();
    }


}
