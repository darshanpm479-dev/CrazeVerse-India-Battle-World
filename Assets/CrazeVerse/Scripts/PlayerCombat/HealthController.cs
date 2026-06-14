using UnityEngine;

namespace CrazeVerse.Combat
{
    public class HealthController : MonoBehaviour
    {
        public bool IsReady { get; private set; }
        public HealthData Health { get; private set; }

        public void Init()
        {
            Health = HealthData.CreateDefault();
            IsReady = true;
        }

        public void SetMaxHealth(int maxHealth)
        {
            EnsureReady();
            Health.maxHealth = Mathf.Max(1, maxHealth);
            Health.currentHealth = Mathf.Clamp(Health.currentHealth, 0, Health.maxHealth);
            Health.isAlive = Health.currentHealth > 0;
        }

        public void RestoreFullHealth()
        {
            EnsureReady();
            Health.currentHealth = Health.maxHealth;
            Health.isAlive = true;
        }

        public void SetInvulnerable(bool value)
        {
            EnsureReady();
            Health.isInvulnerable = value;
        }

        public void ApplyPreviewHealthChange(int amount, DamageType damageType)
        {
            EnsureReady();

            if (damageType == DamageType.Healing)
            {
                Health.currentHealth = Mathf.Clamp(Health.currentHealth + Mathf.Abs(amount), 0, Health.maxHealth);
            }
            else if (!Health.isInvulnerable)
            {
                Health.currentHealth = Mathf.Clamp(Health.currentHealth - Mathf.Abs(amount), 0, Health.maxHealth);
            }

            Health.isAlive = Health.currentHealth > 0;
            // TODO: This is local data preview only. Real combat can be added later only after approval.
        }

        public bool IsAlive()
        {
            EnsureReady();
            return Health != null && Health.isAlive;
        }

        private void EnsureReady()
        {
            if (!IsReady)
            {
                Init();
            }
        }
    }
}
