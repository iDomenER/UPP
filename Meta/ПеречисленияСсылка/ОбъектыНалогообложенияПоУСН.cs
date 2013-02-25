﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ОбъектыНалогообложенияПоУСН
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"ca61a7e9-1752-4cff-bd51-c766b491fa59\", \"Представление\":\"Доходы\"}")]
		Доходы = 0,
		[EnumMember(Value = "{\"Ссылка\":\"e6808920-8017-4068-b6ab-cc5caf22aa64\", \"Представление\":\"ДоходыМинусРасходы\"}")]
		ДоходыМинусРасходы = 1,//Доходы, уменьшенные на величину расходов
	}
	public static partial class ОбъектыНалогообложенияПоУСН_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Доходы = new Guid("66c751bd-91b4-59fa-4cff-1752ca61a7e9");
		public static readonly Guid ДоходыМинусРасходы = new Guid("5cccabb6-22af-64aa-4068-8017e6808920");//Доходы, уменьшенные на величину расходов
		public static ОбъектыНалогообложенияПоУСН Получить(this ОбъектыНалогообложенияПоУСН Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ОбъектыНалогообложенияПоУСН Получить(this ОбъектыНалогообложенияПоУСН Значение, Guid Ссылка)
		{
			if(Ссылка == Доходы)
			{
				return ОбъектыНалогообложенияПоУСН.Доходы;
			}
			else if(Ссылка == ДоходыМинусРасходы)
			{
				return ОбъектыНалогообложенияПоУСН.ДоходыМинусРасходы;
			}
			return ОбъектыНалогообложенияПоУСН.ПустаяСсылка;
		}
		public static byte[] Ключ(this ОбъектыНалогообложенияПоУСН Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ОбъектыНалогообложенияПоУСН Значение)
		{
			switch (Значение)
			{
				case ОбъектыНалогообложенияПоУСН.Доходы: return Доходы;
				case ОбъектыНалогообложенияПоУСН.ДоходыМинусРасходы: return ДоходыМинусРасходы;
			}
			return Guid.Empty;
		}
	}
}