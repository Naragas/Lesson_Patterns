using UnityEngine;


namespace DefaultNamespace
{
    public sealed class PlayerHP : MonoBehaviour, IInteractable
    {
        [SerializeField] private float _hp;
        [SerializeField] private float _maxHp = 100;

        public void SetValue(float value)
        {
            bool posNeg = value > 0 ? Heal(value) : Damage(value);
        }

        private bool Damage(float damageValue)
        {
            _hp = ((_hp + damageValue) < 0) ? 0 : (_hp + damageValue);
            return false;
        }

        private bool Heal(float healValue)
        {
            _hp = ((_hp + healValue) > _maxHp) ? _maxHp : (_hp + healValue);
            return true;
        }
    }
}
