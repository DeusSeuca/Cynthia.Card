using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("62013")]//坎比
	public class Kambi : CardEffect
	{//间谍。遗愿：生成“汉姆多尔”。
		public Kambi(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}