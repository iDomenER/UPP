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
	public enum СтретегииСписанияПартийТоваровПоСтатусам
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"04adc542-76f4-44bb-890a-8940d41ad30d\", \"Представление\":\"СначалаПринятыеПотомСобственные\"}")]
		СначалаПринятыеПотомСобственные = 0,//Сначала принятые потом собственные
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"e27d775b-bd9f-43b1-b13d-2f6c4c2175bb\", \"Представление\":\"СначалаСобственныеПотомПринятые\"}")]
		СначалаСобственныеПотомПринятые = 1,//Сначала собственные потом принятые
	}
	public static partial class СтретегииСписанияПартийТоваровПоСтатусам_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СначалаПринятыеПотомСобственные = new Guid("40890a89-1ad4-0dd3-44bb-76f404adc542");//Сначала принятые потом собственные
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СначалаСобственныеПотомПринятые = new Guid("6c2f3db1-214c-bb75-43b1-bd9fe27d775b");//Сначала собственные потом принятые
		public static СтретегииСписанияПартийТоваровПоСтатусам Получить(this СтретегииСписанияПартийТоваровПоСтатусам Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СтретегииСписанияПартийТоваровПоСтатусам Получить(this СтретегииСписанияПартийТоваровПоСтатусам Значение, Guid Ссылка)
		{
			if(Ссылка == СначалаПринятыеПотомСобственные)
			{
				return СтретегииСписанияПартийТоваровПоСтатусам.СначалаПринятыеПотомСобственные;
			}
			else if(Ссылка == СначалаСобственныеПотомПринятые)
			{
				return СтретегииСписанияПартийТоваровПоСтатусам.СначалаСобственныеПотомПринятые;
			}
			return СтретегииСписанияПартийТоваровПоСтатусам.ПустаяСсылка;
		}
		public static byte[] Ключ(this СтретегииСписанияПартийТоваровПоСтатусам Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СтретегииСписанияПартийТоваровПоСтатусам Значение)
		{
			switch (Значение)
			{
				case СтретегииСписанияПартийТоваровПоСтатусам.СначалаПринятыеПотомСобственные: return СначалаПринятыеПотомСобственные;
				case СтретегииСписанияПартийТоваровПоСтатусам.СначалаСобственныеПотомПринятые: return СначалаСобственныеПотомПринятые;
			}
			return Guid.Empty;
		}
	}
}