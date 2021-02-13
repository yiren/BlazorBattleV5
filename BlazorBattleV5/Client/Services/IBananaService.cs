using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattleV5.Client.Services
{
    public interface IBananaService
    {
        public event Action OnChange;
        public int Banana { get; }

        public void AddBananas(int amount);

        public void EatBananas(int amount);
    }
}
