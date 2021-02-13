using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattleV5.Client.Services
{
    public class BananaService : IBananaService
    {
        public event Action OnChange;
        public int Banana { get; private set; } = 1000;

        public void AddBananas(int amount)
        {
            Banana += amount;
            BananaChanged();
        }

        public void EatBananas(int amount)
        {
            Banana -= amount;
            BananaChanged();
        }

        void BananaChanged() => OnChange.Invoke();
    }
}
