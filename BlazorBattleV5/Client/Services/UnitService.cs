using BlazorBattleV5.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattleV5.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<Unit> Units { get;} = new List<Unit>
        {
            new Unit { UnitId=1, Title="Knight", Attack=10, Defense=10, BananaCost=100},
            new Unit { UnitId = 2, Title = "Archer", Attack = 15, Defense = 5, BananaCost = 150 },
            new Unit { UnitId = 3, Title = "Mage", Attack = 20, Defense = 1, BananaCost = 200 },
        };

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            Unit unit = Units.First(u => u.UnitId == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.UnitId, HitPoints = unit.HitPoints });
        }
    }
}
