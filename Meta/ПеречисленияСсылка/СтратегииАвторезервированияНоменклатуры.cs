﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum СтратегииАвторезервированияНоменклатуры
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"7b88ef98-903d-470f-8f11-ce7f34599f51\", \"Представление\":\"СначалаНаСкладахПотомВЗаказахПоставщикам\"}")]
		СначалаНаСкладахПотомВЗаказахПоставщикам = 0,//Сначала на складах, потом в заказах поставщикам
		[EnumMember(Value = "{\"Ссылка\":\"4839d7e6-5edc-452e-895c-c6acbf69c27a\", \"Представление\":\"СначалаВЗаказахПоставщикамПотомНаСкладах\"}")]
		СначалаВЗаказахПоставщикамПотомНаСкладах = 1,//Сначала в заказах поставщикам, потом на складах
	}
	public static partial class СтратегииАвторезервированияНоменклатуры_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СначалаНаСкладахПотомВЗаказахПоставщикам = new Guid("7fce118f-5934-519f-470f-903d7b88ef98");//Сначала на складах, потом в заказах поставщикам
		public static readonly Guid СначалаВЗаказахПоставщикамПотомНаСкладах = new Guid("acc65c89-69bf-7ac2-452e-5edc4839d7e6");//Сначала в заказах поставщикам, потом на складах
		public static СтратегииАвторезервированияНоменклатуры Получить(this СтратегииАвторезервированияНоменклатуры Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СтратегииАвторезервированияНоменклатуры Получить(this СтратегииАвторезервированияНоменклатуры Значение, Guid Ссылка)
		{
			if(Ссылка == СначалаНаСкладахПотомВЗаказахПоставщикам)
			{
				return СтратегииАвторезервированияНоменклатуры.СначалаНаСкладахПотомВЗаказахПоставщикам;
			}
			else if(Ссылка == СначалаВЗаказахПоставщикамПотомНаСкладах)
			{
				return СтратегииАвторезервированияНоменклатуры.СначалаВЗаказахПоставщикамПотомНаСкладах;
			}
			return СтратегииАвторезервированияНоменклатуры.ПустаяСсылка;
		}
		public static byte[] Ключ(this СтратегииАвторезервированияНоменклатуры Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СтратегииАвторезервированияНоменклатуры Значение)
		{
			switch (Значение)
			{
				case СтратегииАвторезервированияНоменклатуры.СначалаНаСкладахПотомВЗаказахПоставщикам: return СначалаНаСкладахПотомВЗаказахПоставщикам;
				case СтратегииАвторезервированияНоменклатуры.СначалаВЗаказахПоставщикамПотомНаСкладах: return СначалаВЗаказахПоставщикамПотомНаСкладах;
			}
			return Guid.Empty;
		}
	}
}