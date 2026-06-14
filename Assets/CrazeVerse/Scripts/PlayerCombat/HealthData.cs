namespace CrazeVerse.Combat
{
    [System.Serializable]
    public class HealthData
    {
        public int maxHealth;
        public int currentHealth;
        public int shield;
        public bool isAlive;
        public bool isInvulnerable;

        public static HealthData CreateDefault()
        {
            return new HealthData
            {
                maxHealth = 100,
                currentHealth = 100,
                shield = 0,
                isAlive = true,
                isInvulnerable = false
            };
        }

        public float GetHealthPercent()
        {
            if (maxHealth <= 0)
            {
                return 0f;
            }

            return (float)currentHealth / maxHealth;
        }
    }
}
