using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragObject : MonoBehaviour, IDragHandler , IBeginDragHandler, IEndDragHandler
{
    private RectTransform _rectTransform;
    private Image _image;
    [SerializeField] private bool isDraggable; 
    
    

    [ShowInInspector, ReadOnly] public DropObjectSlot holdingParent;
    public int id;


    [SerializeField] private Transform beginPosition; 
    

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _image = GetComponent<Image>();
    }
    

    public void OnDrag(PointerEventData eventData)
    {
        if (!isDraggable)
            return; 
        _rectTransform.anchoredPosition += eventData.delta;

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!isDraggable)
            return; 
        _image.color = new Color32(255, 255, 255, 100);
        _image.raycastTarget = false;
        holdingParent = null;
        transform.SetParent(transform.root);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _image.color = new Color32(255, 255, 255, 255);
        _image.raycastTarget = true;
        transform.SetParent(holdingParent is null ? transform.root : holdingParent.transform);
    }
    
    public void ResetPosition()
    {
        transform.position = beginPosition.position;
    }
    
    
    
    
}
