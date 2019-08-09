using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("64017")]//迪门家族轻型长船
	public class DimunLightLongship : CardEffect
	{//回合结束时，对右侧的单位造成1点伤害，自身获得2点增益。
		public DimunLightLongship(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}