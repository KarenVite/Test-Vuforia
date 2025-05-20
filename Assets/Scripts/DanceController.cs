using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
   [SerializeField]
   private UnityEvent _onActivateSelectedDance;
   [SerializeField]
   private UnityEvent _onSelectDance;

   public void ActivateSelectedDance()
   {
    _onActivateSelectedDance.Invoke();
   }

   public void SelectDance()
   {
    _onSelectDance.Invoke();
   }
}
