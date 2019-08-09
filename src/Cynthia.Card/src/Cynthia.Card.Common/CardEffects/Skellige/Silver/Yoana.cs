using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("63013")]//尤娜
	public class Yoana : CardEffect
	{//治愈1个友军单位，随后使其获得等同于治疗量的增益。
		public Yoana(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}