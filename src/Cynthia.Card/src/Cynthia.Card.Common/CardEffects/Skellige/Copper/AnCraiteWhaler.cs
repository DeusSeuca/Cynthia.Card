using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("64014")]//奎特家族捕鲸鱼叉手
	public class AnCraiteWhaler : CardEffect
	{//将1个敌军单位移至其所在半场的同排，并使它受到等同于所在排单位数量的伤害。
		public AnCraiteWhaler(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}