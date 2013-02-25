﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыЛьготПриНачисленииБольничных
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"c37c19f0-81a9-4198-a2cf-6f96850d089d\", \"Представление\":\"Семипалатинск\"}")]
		Семипалатинск = 0,//Испытаниями на Семипалатинском полигоне
		[EnumMember(Value = "{\"Ссылка\":\"e4159836-05bb-4787-8dcb-9ee0754541ef\", \"Представление\":\"Чернобыль\"}")]
		Чернобыль = 1,//Аварией на Чернобыльской АЭС
		[EnumMember(Value = "{\"Ссылка\":\"26356b48-31b3-4ede-a462-b871b98b41b9\", \"Представление\":\"Маяк\"}")]
		Маяк = 2,//Аварией на ПО "Маяк"
		[EnumMember(Value = "{\"Ссылка\":\"9372c718-a033-4113-95e5-9cc799c92d33\", \"Представление\":\"ПодразделенияОсобогоРиска\"}")]
		ПодразделенияОсобогоРиска = 3,//Работой в подразделениях особого риска
	}
	public static partial class ВидыЛьготПриНачисленииБольничных_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Семипалатинск = new Guid("966fcfa2-0d85-9d08-4198-81a9c37c19f0");//Испытаниями на Семипалатинском полигоне
		public static readonly Guid Чернобыль = new Guid("e09ecb8d-4575-ef41-4787-05bbe4159836");//Аварией на Чернобыльской АЭС
		public static readonly Guid Маяк = new Guid("71b862a4-8bb9-b941-4ede-31b326356b48");//Аварией на ПО "Маяк"
		public static readonly Guid ПодразделенияОсобогоРиска = new Guid("c79ce595-c999-332d-4113-a0339372c718");//Работой в подразделениях особого риска
		public static ВидыЛьготПриНачисленииБольничных Получить(this ВидыЛьготПриНачисленииБольничных Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыЛьготПриНачисленииБольничных Получить(this ВидыЛьготПриНачисленииБольничных Значение, Guid Ссылка)
		{
			if(Ссылка == Семипалатинск)
			{
				return ВидыЛьготПриНачисленииБольничных.Семипалатинск;
			}
			else if(Ссылка == Чернобыль)
			{
				return ВидыЛьготПриНачисленииБольничных.Чернобыль;
			}
			else if(Ссылка == Маяк)
			{
				return ВидыЛьготПриНачисленииБольничных.Маяк;
			}
			else if(Ссылка == ПодразделенияОсобогоРиска)
			{
				return ВидыЛьготПриНачисленииБольничных.ПодразделенияОсобогоРиска;
			}
			return ВидыЛьготПриНачисленииБольничных.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыЛьготПриНачисленииБольничных Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыЛьготПриНачисленииБольничных Значение)
		{
			switch (Значение)
			{
				case ВидыЛьготПриНачисленииБольничных.Семипалатинск: return Семипалатинск;
				case ВидыЛьготПриНачисленииБольничных.Чернобыль: return Чернобыль;
				case ВидыЛьготПриНачисленииБольничных.Маяк: return Маяк;
				case ВидыЛьготПриНачисленииБольничных.ПодразделенияОсобогоРиска: return ПодразделенияОсобогоРиска;
			}
			return Guid.Empty;
		}
	}
}