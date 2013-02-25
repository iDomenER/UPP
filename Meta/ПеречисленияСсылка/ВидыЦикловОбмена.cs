﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыЦикловОбмена
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"159b6e75-aced-4fbc-b1c7-1be64aa8a395\", \"Представление\":\"ЦиклОбменаСФНС\"}")]
		ЦиклОбменаСФНС = 0,//Цикл обмена с ФНС
		[EnumMember(Value = "{\"Ссылка\":\"4ba93636-16f5-46ed-b9c2-60fada9f97d1\", \"Представление\":\"ЦиклОбменаСПФР\"}")]
		ЦиклОбменаСПФР = 1,//Цикл обмена с ПФР
		[EnumMember(Value = "{\"Ссылка\":\"ee1163ab-d682-4bbc-8eda-519f91049764\", \"Представление\":\"ЦиклОбменаСФСГС\"}")]
		ЦиклОбменаСФСГС = 2,//Цикл обмена с Росстатом
	}
	public static partial class ВидыЦикловОбмена_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ЦиклОбменаСФНС = new Guid("e61bc7b1-a84a-95a3-4fbc-aced159b6e75");//Цикл обмена с ФНС
		public static readonly Guid ЦиклОбменаСПФР = new Guid("fa60c2b9-9fda-d197-46ed-16f54ba93636");//Цикл обмена с ПФР
		public static readonly Guid ЦиклОбменаСФСГС = new Guid("9f51da8e-0491-6497-4bbc-d682ee1163ab");//Цикл обмена с Росстатом
		public static ВидыЦикловОбмена Получить(this ВидыЦикловОбмена Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыЦикловОбмена Получить(this ВидыЦикловОбмена Значение, Guid Ссылка)
		{
			if(Ссылка == ЦиклОбменаСФНС)
			{
				return ВидыЦикловОбмена.ЦиклОбменаСФНС;
			}
			else if(Ссылка == ЦиклОбменаСПФР)
			{
				return ВидыЦикловОбмена.ЦиклОбменаСПФР;
			}
			else if(Ссылка == ЦиклОбменаСФСГС)
			{
				return ВидыЦикловОбмена.ЦиклОбменаСФСГС;
			}
			return ВидыЦикловОбмена.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыЦикловОбмена Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыЦикловОбмена Значение)
		{
			switch (Значение)
			{
				case ВидыЦикловОбмена.ЦиклОбменаСФНС: return ЦиклОбменаСФНС;
				case ВидыЦикловОбмена.ЦиклОбменаСПФР: return ЦиклОбменаСПФР;
				case ВидыЦикловОбмена.ЦиклОбменаСФСГС: return ЦиклОбменаСФСГС;
			}
			return Guid.Empty;
		}
	}
}