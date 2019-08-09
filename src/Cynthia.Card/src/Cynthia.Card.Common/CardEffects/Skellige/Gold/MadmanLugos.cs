using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("62008")]//“疯子”卢戈
	public class MadmanLugos : CardEffect
	{//从牌组丢弃1张铜色单位牌，对1个敌军单位造成等同于被丢弃单位基础战力的伤害。
		public MadmanLugos(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}