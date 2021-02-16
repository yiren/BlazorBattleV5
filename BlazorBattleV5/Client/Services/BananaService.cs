using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MudBlazor;
namespace BlazorBattleV5.Client.Services
{
    public class BananaService : IBananaService
    {
        private readonly ISnackbar snackBar;

        public BananaService(ISnackbar snackBar)
        {
            this.snackBar = snackBar;
        }
        public event Action OnChange;
        public int Banana { get; private set; } = 500;

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
