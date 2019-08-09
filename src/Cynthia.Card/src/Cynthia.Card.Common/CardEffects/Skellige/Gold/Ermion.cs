using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("62004")]//莫斯萨克
	public class Ermion : CardEffect
	{//抽2张牌，随后丢弃2张牌。
		public Ermion(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}