using CodeBase.Entities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CodeBase.Unity
{
    public class CardView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        private Card _card;

        private Vector3 _normalPosition;
        
        private Vector3 _normalScale;

        public void Construct(Card card)
        {
            _card = card;
            _normalPosition = transform.position;
            _normalScale = transform.localScale;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            transform.position = transform.position + new Vector3(0f, 1f, 8f);
            transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z * 2);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            transform.localScale = _normalScale;
            transform.position = _normalPosition;
        }
    }
}