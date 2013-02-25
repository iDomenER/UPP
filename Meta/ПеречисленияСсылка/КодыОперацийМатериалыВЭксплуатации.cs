﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum КодыОперацийМатериалыВЭксплуатации
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"cc79e28f-c2f3-4e79-9ea5-623085234cb4\", \"Представление\":\"СписаниеПартийВЭксплуатацию\"}")]
		СписаниеПартийВЭксплуатацию = 0,//Списание партий в эксплуатацию
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"b6fb9292-130c-47a7-9947-ce21fb8d97ce\", \"Представление\":\"ВозвратИзЭксплуатации\"}")]
		ВозвратИзЭксплуатации = 1,//Возврат из эксплуатации
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"d3691aee-930d-48b3-9e26-ad8e54f84bc8\", \"Представление\":\"СписаниеИзЭксплуатации\"}")]
		СписаниеИзЭксплуатации = 2,//Списание из эксплуатации
		[EnumMember(Value = "{\"Ссылка\":\"ca1e6df5-2f15-43d9-981a-235f9560ce30\", \"Представление\":\"ПеремещениеВЭксплуатации\"}")]
		ПеремещениеВЭксплуатации = 3,//Перемещение в эксплуатации
	}
	public static partial class КодыОперацийМатериалыВЭксплуатации_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеПартийВЭксплуатацию = new Guid("3062a59e-2385-b44c-4e79-c2f3cc79e28f");//Списание партий в эксплуатацию
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратИзЭксплуатации = new Guid("21ce4799-8dfb-ce97-47a7-130cb6fb9292");//Возврат из эксплуатации
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеИзЭксплуатации = new Guid("8ead269e-f854-c84b-48b3-930dd3691aee");//Списание из эксплуатации
		public static readonly Guid ПеремещениеВЭксплуатации = new Guid("5f231a98-6095-30ce-43d9-2f15ca1e6df5");//Перемещение в эксплуатации
		public static КодыОперацийМатериалыВЭксплуатации Получить(this КодыОперацийМатериалыВЭксплуатации Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static КодыОперацийМатериалыВЭксплуатации Получить(this КодыОперацийМатериалыВЭксплуатации Значение, Guid Ссылка)
		{
			if(Ссылка == СписаниеПартийВЭксплуатацию)
			{
				return КодыОперацийМатериалыВЭксплуатации.СписаниеПартийВЭксплуатацию;
			}
			else if(Ссылка == ВозвратИзЭксплуатации)
			{
				return КодыОперацийМатериалыВЭксплуатации.ВозвратИзЭксплуатации;
			}
			else if(Ссылка == СписаниеИзЭксплуатации)
			{
				return КодыОперацийМатериалыВЭксплуатации.СписаниеИзЭксплуатации;
			}
			else if(Ссылка == ПеремещениеВЭксплуатации)
			{
				return КодыОперацийМатериалыВЭксплуатации.ПеремещениеВЭксплуатации;
			}
			return КодыОперацийМатериалыВЭксплуатации.ПустаяСсылка;
		}
		public static byte[] Ключ(this КодыОперацийМатериалыВЭксплуатации Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this КодыОперацийМатериалыВЭксплуатации Значение)
		{
			switch (Значение)
			{
				case КодыОперацийМатериалыВЭксплуатации.СписаниеПартийВЭксплуатацию: return СписаниеПартийВЭксплуатацию;
				case КодыОперацийМатериалыВЭксплуатации.ВозвратИзЭксплуатации: return ВозвратИзЭксплуатации;
				case КодыОперацийМатериалыВЭксплуатации.СписаниеИзЭксплуатации: return СписаниеИзЭксплуатации;
				case КодыОперацийМатериалыВЭксплуатации.ПеремещениеВЭксплуатации: return ПеремещениеВЭксплуатации;
			}
			return Guid.Empty;
		}
	}
}