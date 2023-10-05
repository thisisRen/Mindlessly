using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class ObjectCanInteract : MonoBehaviour
{

    public UnityEvent beforeInteractTask;
    public UnityEvent mainTask; 
    public UnityEvent afterInteractTask;
    
    
    public virtual void BeforeInteract()
    {
    }
    
    public virtual void Interact()
    {
        
    }

    public virtual void InteractBehavior()
    {
        
    }
    
}
